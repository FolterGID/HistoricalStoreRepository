using System.Linq.Expressions;

namespace HistoricalStore.Data.Services
{
    public interface ICrudService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllItems(Expression<Func<T, bool>>? filter = null);
        Task<T> GetOneItem(int id);
        Task AddItem(T entity);
        Task UpdateItem(T entity);
        Task DeleteItem(int id);
    }
}
