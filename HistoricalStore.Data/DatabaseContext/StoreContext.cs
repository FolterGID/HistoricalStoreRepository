using HistoricalStore.Data.Models.OrderModels;
using HistoricalStore.Data.Models.ProductModels;
using HistoricalStore.Data.Models.SupplyModels;
using HistoricalStore.Data.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace HistoricalStore.Data.DatabaseContext
{
    public class StoreContext(DbContextOptions<StoreContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Material> Materials { get; set; } = null!;
        public DbSet<HistoricalPeriod> HistoricalPeriods { get; set; } = null!;
        public DbSet<Accessory> Accessories { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Armor> Armors { get; set; } = null!;
        public DbSet<Weapon> Weapons { get; set; } = null!;
        public DbSet<ProductMaterial> ProductMaterials { get; set; } = null!;
        public DbSet<ProductHistoricalPeriod> ProductHistoricalPeriods { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductHistoricalPeriod>()
                .HasKey(php => new { php.ProductId, php.HistoricalPeriodId });

            modelBuilder.Entity<ProductHistoricalPeriod>()
                .HasOne(php => php.Product)
                .WithMany(p => p.ProductHistoricalPeriods)
                .HasForeignKey(php => php.ProductId);

            modelBuilder.Entity<ProductHistoricalPeriod>()
                .HasOne(php => php.HistoricalPeriod)
                .WithMany(hp => hp.ProductHistoricalPeriods)
                .HasForeignKey(php => php.HistoricalPeriodId);

            // Many-to-many for Product-Material
            modelBuilder.Entity<ProductMaterial>()
                .HasKey(pm => new { pm.ProductId, pm.MaterialId });

            modelBuilder.Entity<ProductMaterial>()
                .HasOne(pm => pm.Product)
                .WithMany(p => p.ProductMaterials)
                .HasForeignKey(pm => pm.ProductId);

            modelBuilder.Entity<ProductMaterial>()
                .HasOne(pm => pm.Material)
                .WithMany(m => m.ProductMaterials)
                .HasForeignKey(pm => pm.MaterialId);


            modelBuilder.Entity<Product>()
                .ToTable("Products");

            modelBuilder.Entity<Accessory>()
                .ToTable("Accessories");

            modelBuilder.Entity<Book>()
                .ToTable("Books");

            modelBuilder.Entity<Armor>()
                .ToTable("Armors");

            modelBuilder.Entity<Weapon>()
                .ToTable("Weapons");

            base.OnModelCreating(modelBuilder);
        }
    }
}
