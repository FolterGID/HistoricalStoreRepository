using HistoricalStore.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace HistoricalStore.Data.Services
{
    public class CrudService<T> : ICrudService<T> where T : class
    {
        private readonly StoreContext _context;
        private readonly DbSet<T> _dbSet;

        public CrudService(StoreContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllItems(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null) query = query.Where(filter);
            return await query.AsNoTracking().ToListAsync();
        }
        

        public async Task<T> GetOneItem(int id) => await _dbSet.FindAsync(id);
        

        public async Task AddItem(T item)
        {
            await _dbSet.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateItem(T item)
        {
            _dbSet.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItem(int id)
        {
            if (await _dbSet.FindAsync(id) is T item)
            {
                _dbSet.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
