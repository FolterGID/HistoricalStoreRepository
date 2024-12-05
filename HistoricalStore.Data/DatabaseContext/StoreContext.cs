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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Materials)
                .WithMany(m => m.Products);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.HistoricalPeriods)
                .WithMany(hp => hp.Products);


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

            // Начальные данные для Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Оружие" },
                new Category { Id = 2, Name = "Одежда" },
                new Category { Id = 3, Name = "Книги" },
                new Category { Id = 4, Name = "Сувениры" }
            );

            // Начальные данные для HistoricalPeriod
            modelBuilder.Entity<HistoricalPeriod>().HasData(
                new HistoricalPeriod { Id = 1, Name = "Древний мир" },
                new HistoricalPeriod { Id = 2, Name = "Античность" },
                new HistoricalPeriod { Id = 3, Name = "Средневековье" },
                new HistoricalPeriod { Id = 4, Name = "Ренессанс" },
                new HistoricalPeriod { Id = 5, Name = "Новое время" }
            );

            // Начальные данные для Material
            modelBuilder.Entity<Material>().HasData(
                new Material { Id = 1, Name = "Дерево (дуб)" },
                new Material { Id = 2, Name = "Дерево (кедр)" },
                new Material { Id = 3, Name = "Сталь, закаленная" },
                new Material { Id = 4, Name = "Железо, кованое" },
                new Material { Id = 5, Name = "Золото, 585 проба" },
                new Material { Id = 6, Name = "Серебро, 925 проба" },
                new Material { Id = 7, Name = "Кожа (натуральная, телячья)" },
                new Material { Id = 8, Name = "Кожа (замша, натуральная)" },
                new Material { Id = 9, Name = "Ткань (лен, грубый)" },
                new Material { Id = 10, Name = "Ткань (шелк, китайский)" },
                new Material { Id = 11, Name = "Керамика (майолика)" },
                new Material { Id = 12, Name = "Керамика (фарфор, европейский)" },
                new Material { Id = 13, Name = "Мрамор, каррарский" }
            );

            // Начальные данные для Role
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Администратор" },
                new Role { Id = 2, Name = "Менеджер" },
                new Role { Id = 3, Name = "Клиент" },
                new Role { Id = 4, Name = "Гость" }
            );

            //Начальные данные для OrderStatus
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, Name = "Ожидание" },
                new OrderStatus { Id = 2, Name = "В процессе" },
                new OrderStatus { Id = 3, Name = "Отправлено" },
                new OrderStatus { Id = 4, Name = "Доставлено" },
                new OrderStatus { Id = 5, Name = "Отменено" }
            );
        }
    }
}
