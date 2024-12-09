using HistoricalStore.Data.Models.OrderModels;
using HistoricalStore.Data.Models.ProductModels;
using HistoricalStore.Data.Models.SupplyModels;
using HistoricalStore.Data.Models.SupplyModels.Types;
using HistoricalStore.Data.Models.UserModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HistoricalStore.Data.DatabaseContext
{
    public class StoreContext(DbContextOptions<StoreContext> options) : IdentityDbContext<User>(options)
    {
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
        public DbSet<Clothing> Clothings { get; set; } = null!;
        public DbSet<Souvenir> Souvenirs { get; set; } = null!;
        public DbSet<AccessoryType> AccessoryTypes { get; set; } = null!;
        public DbSet<ArmorType> ArmorTypes { get; set; } = null!;
        public DbSet<SouvenirType> SouvenirTypes { get; set; } = null!;
        public DbSet<WeaponType> WeaponTypes { get; set; } = null!;


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

            modelBuilder.Entity<Clothing>()
                .ToTable("Clothings");

            modelBuilder.Entity<Souvenir>()
                .ToTable("Souvenirs");

            base.OnModelCreating(modelBuilder);

            // Начальные данные для Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Оружие" },
                new Category { Id = 2, Name = "Доспехи" },
                new Category { Id = 3, Name = "Одежда" },
                new Category { Id = 4, Name = "Книги" },
                new Category { Id = 5, Name = "Аксессуары" },
                new Category { Id = 6, Name = "Сувениры" }
            );

            // Начальные данные для HistoricalPeriod
            modelBuilder.Entity<HistoricalPeriod>().HasData(
                new HistoricalPeriod { Id = 1, Name = "Древний мир" },
                new HistoricalPeriod { Id = 2, Name = "Античность" },
                new HistoricalPeriod { Id = 3, Name = "Средневековье" },
                new HistoricalPeriod { Id = 4, Name = "Эпоха возрождения" },
                new HistoricalPeriod { Id = 5, Name = "Новое время" }
            );

            // Начальные данные для Material
            modelBuilder.Entity<Material>().HasData(
                new Material { Id = 1, Name = "Сталь", Description = "Кованая сталь, используется для оружия и доспехов." },
                new Material { Id = 2, Name = "Железо", Description = "Чугун, гладкое железо, использовались в производстве оружия." },
                new Material { Id = 3, Name = "Бронза", Description = "Латунь и бронзовые сплавы использовались для оружия и украшений." },
                new Material { Id = 4, Name = "Медь", Description = "Медь, использовалась в старинных оружиях и декоративных предметах." },
                new Material { Id = 5, Name = "Золото", Description = "Ценный металл, использовался для украшений и монет." },
                new Material { Id = 6, Name = "Серебро", Description = "Применялось в украшениях и декоративных предметах." },
                new Material { Id = 7, Name = "Титан", Description = "Используется в современном оружии и доспехах." },
                new Material { Id = 8, Name = "Молибден", Description = "Сплавляется для использования в различных оружейных изделиях." },
                new Material { Id = 9, Name = "Цинк", Description = "Применяется в различных металлических сплавах и покрытиях." },
                new Material { Id = 10, Name = "Алюминий", Description = "Используется в легких оружиях и доспехах." },
                new Material { Id = 11, Name = "Платина", Description = "Ценный металл, используется в украшениях." },
                new Material { Id = 12, Name = "Родий", Description = "Реже используется в ювелирных изделиях." },
                new Material { Id = 13, Name = "Рубин", Description = "Драгоценный камень, использовался для украшений." },
                new Material { Id = 14, Name = "Сапфир", Description = "Применяется в украшениях и декоративных элементах." },
                new Material { Id = 15, Name = "Изумруд", Description = "Драгоценный камень, используемый в ювелирных украшениях." },
                new Material { Id = 16, Name = "Алмаз", Description = "Ценный камень, использовался в орнаментах и украшениях." },
                new Material { Id = 17, Name = "Турмалин", Description = "Полудрагоценный камень, использовался в украшениях." },
                new Material { Id = 18, Name = "Лазурит", Description = "Драгоценный камень, применялся для ювелирных украшений." },
                new Material { Id = 19, Name = "Дуб", Description = "Твердое дерево, использовалось в оружии и мебели." },
                new Material { Id = 20, Name = "Орех", Description = "Древесина, применялась для мебели и аксессуаров." },
                new Material { Id = 21, Name = "Клен", Description = "Древесина для отделки мебели и декоративных изделий." },
                new Material { Id = 22, Name = "Лиственница", Description = "Используется для мебели и изделий для наружного применения." },
                new Material { Id = 23, Name = "Махагон", Description = "Ценный вид древесины, используемый в мебели и аксессуарах." },
                new Material { Id = 24, Name = "Вишня", Description = "Твердое дерево, использовалось для производства мебели." },
                new Material { Id = 25, Name = "Тик", Description = "Тик использовался в производстве мебели и для декоративных изделий." },
                new Material { Id = 26, Name = "Кедр", Description = "Используется в производстве мебели и элементов интерьера." },
                new Material { Id = 27, Name = "Шерсть", Description = "Шерстяные ткани использовались для производства одежды." },
                new Material { Id = 28, Name = "Лён", Description = "Льняные ткани использовались для одежды и тканей." },
                new Material { Id = 29, Name = "Шелк", Description = "Ценный материал для тканей и аксессуаров." },
                new Material { Id = 30, Name = "Барс", Description = "Шерсть для одежды и тканей, использовалась для одежды." },
                new Material { Id = 31, Name = "Кашемир", Description = "Мягкая шерсть, использовалась для тканей." },
                new Material { Id = 32, Name = "Деним", Description = "Деним использовался для одежды, в частности для джинсов." },
                new Material { Id = 33, Name = "Полиэстер", Description = "Современный синтетический материал, использующийся в одежде и аксессуарах." },
                new Material { Id = 34, Name = "Пластик", Description = "Современный синтетический материал для декоративных элементов и сувениров." },
                new Material { Id = 35, Name = "Стекло", Description = "Используется для различных декоративных предметов." },
                new Material { Id = 36, Name = "Фарфор", Description = "Керамика, используемая для посуды и сувениров." },
                new Material { Id = 37, Name = "Перья", Description = "Используются в украшениях и аксессуарах." },
                new Material { Id = 38, Name = "Рог", Description = "Используется для создания украшений и декоративных элементов." },
                new Material { Id = 39, Name = "Кости", Description = "Использовались для украшений и декоративных элементов." },
                new Material { Id = 40, Name = "Гранат", Description = "Полудрагоценный камень, применяющийся для украшений." },
                new Material { Id = 41, Name = "Коралл", Description = "Используется для украшений и декоративных элементов." },
                new Material { Id = 42, Name = "Песчаник", Description = "Камень, использующийся в строительстве и для декоративных элементов." },
                new Material { Id = 43, Name = "Гипс", Description = "Используется для создания декоративных элементов и статуй." },
                new Material { Id = 44, Name = "Глиняные материалы", Description = "Применяются для создания посуды и декоративных элементов." },
                new Material { Id = 45, Name = "Мрамор", Description = "Применяется в архитектуре, статуях и декоративных элементах." }
            );

            // Начальные данные для Role
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = "1", Name = "Администратор" },
                new Role { Id = "2", Name = "Менеджер" },
                new Role { Id = "3", Name = "Клиент" },
                new Role { Id = "4", Name = "Гость" }
            );

            //Начальные данные для OrderStatus
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, Name = "Ожидание" },
                new OrderStatus { Id = 2, Name = "В процессе" },
                new OrderStatus { Id = 3, Name = "Отправлено" },
                new OrderStatus { Id = 4, Name = "Доставлено" },
                new OrderStatus { Id = 5, Name = "Отменено" }
            );

            modelBuilder.Entity<WeaponType>().HasData(
                new WeaponType { Id = 1, Name = "Мечи" },
                new WeaponType { Id = 2, Name = "Кинжалы" },
                new WeaponType { Id = 3, Name = "Топоры" },
                new WeaponType { Id = 4, Name = "Булавы" },
                new WeaponType { Id = 5, Name = "Копья" },
                new WeaponType { Id = 6, Name = "Алебарды" },
                new WeaponType { Id = 7, Name = "Луки" },
                new WeaponType { Id = 8, Name = "Арбалеты" },
                new WeaponType { Id = 9, Name = "Дротики" },
                new WeaponType { Id = 10, Name = "Мушкеты" },
                new WeaponType { Id = 11, Name = "Пистолеты" },
                new WeaponType { Id = 12, Name = "Ружья" },
                new WeaponType { Id = 13, Name = "Катаны" },
                new WeaponType { Id = 14, Name = "Чакрамы" },
                new WeaponType { Id = 15, Name = "Нунчаки" }
            );

            modelBuilder.Entity<ArmorType>().HasData(
                new ArmorType { Id = 1, Name = "Латы" },
                new ArmorType { Id = 2, Name = "Кираса" },
                new ArmorType { Id = 3, Name = "Кольчуга" },
                new ArmorType { Id = 4, Name = "Панцирь" },
                new ArmorType { Id = 5, Name = "Нагрудники" },
                new ArmorType { Id = 6, Name = "Шлемы" },
                new ArmorType { Id = 7, Name = "Маски" },
                new ArmorType { Id = 8, Name = "Наплечники" },
                new ArmorType { Id = 9, Name = "Наручи" },
                new ArmorType { Id = 10, Name = "Рукавицы" },
                new ArmorType { Id = 11, Name = "Набедренники" },
                new ArmorType { Id = 12, Name = "Коленные щитки" },
                new ArmorType { Id = 13, Name = "Наголенники" },
                new ArmorType { Id = 14, Name = "Сапоги" },
                new ArmorType { Id = 15, Name = "Самурайские доспехи" },
                new ArmorType { Id = 16, Name = "Ламеллярные доспехи" }
            );

            modelBuilder.Entity<ClothingType>().HasData(
                new ClothingType { Id = 1, Name = "Туники" },
                new ClothingType { Id = 2, Name = "Тоги" },
                new ClothingType { Id = 3, Name = "Хитоны" },
                new ClothingType { Id = 4, Name = "Гиматии" },
                new ClothingType { Id = 5, Name = "Каунаки" },
                new ClothingType { Id = 6, Name = "Пеплос" },

                // Средневековье
                new ClothingType { Id = 7, Name = "Сюрко" },
                new ClothingType { Id = 8, Name = "Камизы" },
                new ClothingType { Id = 9, Name = "Гамбезоны" },
                new ClothingType { Id = 10, Name = "Дублеты" },
                new ClothingType { Id = 11, Name = "Кафтан" },
                new ClothingType { Id = 12, Name = "Хауберк" },
                new ClothingType { Id = 13, Name = "Капюшоны" },
                new ClothingType { Id = 14, Name = "Мантии" },
                new ClothingType { Id = 15, Name = "Жупан" },
                new ClothingType { Id = 16, Name = "Хосы" },

                // Ренессанс
                new ClothingType { Id = 17, Name = "Камзолы" },
                new ClothingType { Id = 18, Name = "Бри" },
                new ClothingType { Id = 19, Name = "Лифы" },
                new ClothingType { Id = 20, Name = "Панталоны" },
                new ClothingType { Id = 21, Name = "Плащи" },
                new ClothingType { Id = 22, Name = "Береты" },

                // Азия
                new ClothingType { Id = 23, Name = "Кимоно" },
                new ClothingType { Id = 24, Name = "Хакама" },
                new ClothingType { Id = 25, Name = "Ханьфу" },
                new ClothingType { Id = 26, Name = "Сарис" },
                new ClothingType { Id = 27, Name = "Тюбетейки" },
                new ClothingType { Id = 28, Name = "Чжуншаньчжуань" },

                // Новый свет и колониальная эпоха
                new ClothingType { Id = 29, Name = "Пончо" },
                new ClothingType { Id = 30, Name = "Сомбреро" },
                new ClothingType { Id = 31, Name = "Пальто-трико" },
                new ClothingType { Id = 32, Name = "Рубашки с жабо" },
                new ClothingType { Id = 33, Name = "Корсеты" },

                // Функциональная одежда
                new ClothingType { Id = 34, Name = "Монашеские одеяния" },
                new ClothingType { Id = 35, Name = "Рабочая одежда" },
                new ClothingType { Id = 36, Name = "Военная форма" },
                new ClothingType { Id = 37, Name = "Торговые одеяния" },

                // Церемониальная одежда
                new ClothingType { Id = 38, Name = "Одежда фараонов" },
                new ClothingType { Id = 39, Name = "Жреческие одежды" },
                new ClothingType { Id = 40, Name = "Императорские мантии" },
                new ClothingType { Id = 41, Name = "Королевские одежды" },
                new ClothingType { Id = 42, Name = "Духовные ризы" }
            );

            modelBuilder.Entity<AccessoryType>().HasData(
                // Украшения
                new AccessoryType { Id = 1, Name = "Кулоны" },
                new AccessoryType { Id = 2, Name = "Броши" },
                new AccessoryType { Id = 3, Name = "Перстни" },
                new AccessoryType { Id = 4, Name = "Диадемы" },
                new AccessoryType { Id = 5, Name = "Тиары" },
                new AccessoryType { Id = 6, Name = "Бусы" },
                new AccessoryType { Id = 7, Name = "Серьги" },
                new AccessoryType { Id = 8, Name = "Браслеты" },
                new AccessoryType { Id = 9, Name = "Обручи" },

                // Головные уборы
                new AccessoryType { Id = 10, Name = "Венцы" },
                new AccessoryType { Id = 11, Name = "Шляпы" },
                new AccessoryType { Id = 12, Name = "Повязки на голову" },
                new AccessoryType { Id = 13, Name = "Вуали" },
                new AccessoryType { Id = 14, Name = "Маски" },

                // Ремни и пояса
                new AccessoryType { Id = 15, Name = "Пояса" },
                new AccessoryType { Id = 16, Name = "Военные пояса" },
                new AccessoryType { Id = 17, Name = "Портупеи" },
                new AccessoryType { Id = 18, Name = "Церемониальные ремни" },

                // Сумки
                new AccessoryType { Id = 19, Name = "Сумки через плечо" },
                new AccessoryType { Id = 20, Name = "Походные мешки" },
                new AccessoryType { Id = 21, Name = "Саквояжи" },
                new AccessoryType { Id = 22, Name = "Кошельки" },

                // Обувь
                new AccessoryType { Id = 23, Name = "Сапоги" },
                new AccessoryType { Id = 24, Name = "Сандалии" },
                new AccessoryType { Id = 25, Name = "Калиги" },
                new AccessoryType { Id = 26, Name = "Башмаки" },
                new AccessoryType { Id = 27, Name = "Гетры" },

                // Шарфы и накидки
                new AccessoryType { Id = 28, Name = "Платки" },
                new AccessoryType { Id = 29, Name = "Горжетки" },
                new AccessoryType { Id = 30, Name = "Накидки" },

                // Личный обиход
                new AccessoryType { Id = 31, Name = "Веера" },
                new AccessoryType { Id = 32, Name = "Зонты" },
                new AccessoryType { Id = 33, Name = "Табакерки" },
                new AccessoryType { Id = 34, Name = "Лорнеты" },
                new AccessoryType { Id = 35, Name = "Чётки" },

                // Оружие как аксессуар
                new AccessoryType { Id = 36, Name = "Кинжалы" },
                new AccessoryType { Id = 37, Name = "Палаши" },
                new AccessoryType { Id = 38, Name = "Церемониальные мечи" },

                // Символические аксессуары
                new AccessoryType { Id = 39, Name = "Орденские знаки" },
                new AccessoryType { Id = 40, Name = "Амулеты" },
                new AccessoryType { Id = 41, Name = "Тотемы" },

                // Другое
                new AccessoryType { Id = 42, Name = "Ключи" },
                new AccessoryType { Id = 43, Name = "Колокольчики" },
                new AccessoryType { Id = 44, Name = "Золотые цепи" }
            );

            modelBuilder.Entity<SouvenirType>().HasData(
                new SouvenirType { Id = 1, Name = "Миниатюрные модели оружия" },
                new SouvenirType { Id = 2, Name = "Миниатюрные модели доспехов" },
                new SouvenirType { Id = 3, Name = "Модели щитов" },

                // Книги и карты
                new SouvenirType { Id = 4, Name = "Реплики карт" },
                new SouvenirType { Id = 5, Name = "Исторические книги" },

                // Монеты и медали
                new SouvenirType { Id = 6, Name = "Реплики монет" },
                new SouvenirType { Id = 7, Name = "Памятные медали" },

                // Артефакты
                new SouvenirType { Id = 8, Name = "Реплики статуй" },
                new SouvenirType { Id = 9, Name = "Реплики сосудов" },

                // Мебель и утварь
                new SouvenirType { Id = 10, Name = "Реплики мебели" },
                new SouvenirType { Id = 11, Name = "Кухонные принадлежности" },

                // Ткани и текстиль
                new SouvenirType { Id = 12, Name = "Реплики тканей" },
                new SouvenirType { Id = 13, Name = "Гобелены" },

                // Часы и механизмы
                new SouvenirType { Id = 14, Name = "Реплики старинных часов" },
                new SouvenirType { Id = 15, Name = "Антикварные механизмы" },

                // Ювелирные изделия
                new SouvenirType { Id = 16, Name = "Ювелирные украшения" }
            );


        }
    }
}
