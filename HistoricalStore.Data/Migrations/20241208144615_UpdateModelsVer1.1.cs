using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HistoricalStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelsVer11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeaponType",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "ArmorType",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "AccessoryType",
                table: "Accessories");

            migrationBuilder.AddColumn<int>(
                name: "WeaponTypeId",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ArmorTypeId",
                table: "Armors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccessoryTypeId",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AccessoryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clothings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ClothingTypeId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothings_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClothingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClothingTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothingType_ClothingType_ClothingTypeId",
                        column: x => x.ClothingTypeId,
                        principalTable: "ClothingType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SouvenirTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SouvenirTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Souvenirs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SouvenirTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Souvenirs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Souvenirs_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Souvenirs_SouvenirTypes_SouvenirTypeId",
                        column: x => x.SouvenirTypeId,
                        principalTable: "SouvenirTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccessoryTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Кулоны" },
                    { 2, "Броши" },
                    { 3, "Перстни" },
                    { 4, "Диадемы" },
                    { 5, "Тиары" },
                    { 6, "Бусы" },
                    { 7, "Серьги" },
                    { 8, "Браслеты" },
                    { 9, "Обручи" },
                    { 10, "Венцы" },
                    { 11, "Шляпы" },
                    { 12, "Повязки на голову" },
                    { 13, "Вуали" },
                    { 14, "Маски" },
                    { 15, "Пояса" },
                    { 16, "Военные пояса" },
                    { 17, "Портупеи" },
                    { 18, "Церемониальные ремни" },
                    { 19, "Сумки через плечо" },
                    { 20, "Походные мешки" },
                    { 21, "Саквояжи" },
                    { 22, "Кошельки" },
                    { 23, "Сапоги" },
                    { 24, "Сандалии" },
                    { 25, "Калиги" },
                    { 26, "Башмаки" },
                    { 27, "Гетры" },
                    { 28, "Платки" },
                    { 29, "Горжетки" },
                    { 30, "Накидки" },
                    { 31, "Веера" },
                    { 32, "Зонты" },
                    { 33, "Табакерки" },
                    { 34, "Лорнеты" },
                    { 35, "Чётки" },
                    { 36, "Кинжалы" },
                    { 37, "Палаши" },
                    { 38, "Церемониальные мечи" },
                    { 39, "Орденские знаки" },
                    { 40, "Амулеты" },
                    { 41, "Тотемы" },
                    { 42, "Ключи" },
                    { 43, "Колокольчики" },
                    { 44, "Золотые цепи" }
                });

            migrationBuilder.InsertData(
                table: "ArmorTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Латы" },
                    { 2, "Кираса" },
                    { 3, "Кольчуга" },
                    { 4, "Панцирь" },
                    { 5, "Нагрудники" },
                    { 6, "Шлемы" },
                    { 7, "Маски" },
                    { 8, "Наплечники" },
                    { 9, "Наручи" },
                    { 10, "Рукавицы" },
                    { 11, "Набедренники" },
                    { 12, "Коленные щитки" },
                    { 13, "Наголенники" },
                    { 14, "Сапоги" },
                    { 15, "Самурайские доспехи" },
                    { 16, "Индийские ламеллярные доспехи" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Доспехи");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Одежда");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Книги");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Аксессуары" },
                    { 6, "Сувениры" }
                });

            migrationBuilder.InsertData(
                table: "ClothingType",
                columns: new[] { "Id", "ClothingTypeId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Туники" },
                    { 2, null, "Тоги" },
                    { 3, null, "Хитоны" },
                    { 4, null, "Гиматии" },
                    { 5, null, "Каунаки" },
                    { 6, null, "Пеплос" },
                    { 7, null, "Сюрко" },
                    { 8, null, "Камизы" },
                    { 9, null, "Гамбезоны" },
                    { 10, null, "Дублеты" },
                    { 11, null, "Кафтан" },
                    { 12, null, "Хауберк" },
                    { 13, null, "Капюшоны" },
                    { 14, null, "Мантии" },
                    { 15, null, "Жупан" },
                    { 16, null, "Хосы" },
                    { 17, null, "Камзолы" },
                    { 18, null, "Бри" },
                    { 19, null, "Лифы" },
                    { 20, null, "Панталоны" },
                    { 21, null, "Плащи" },
                    { 22, null, "Береты" },
                    { 23, null, "Кимоно" },
                    { 24, null, "Хакама" },
                    { 25, null, "Ханьфу" },
                    { 26, null, "Сарис" },
                    { 27, null, "Тюбетейки" },
                    { 28, null, "Чжуншаньчжуань" },
                    { 29, null, "Пончо" },
                    { 30, null, "Сомбреро" },
                    { 31, null, "Пальто-трико" },
                    { 32, null, "Рубашки с жабо" },
                    { 33, null, "Корсеты" },
                    { 34, null, "Монашеские одеяния" },
                    { 35, null, "Рабочая одежда" },
                    { 36, null, "Военная форма" },
                    { 37, null, "Торговые одеяния" },
                    { 38, null, "Одежда фараонов" },
                    { 39, null, "Жреческие одежды" },
                    { 40, null, "Императорские мантии" },
                    { 41, null, "Королевские одежды" },
                    { 42, null, "Духовные ризы" }
                });

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Эпоха возрождения");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Кованая сталь, используется для оружия и доспехов.", "Сталь" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Чугун, гладкое железо, использовались в производстве оружия.", "Железо" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Латунь и бронзовые сплавы использовались для оружия и украшений.", "Бронза" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Медь, использовалась в старинных оружиях и декоративных предметах.", "Медь" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ценный металл, использовался для украшений и монет.", "Золото" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Применялось в украшениях и декоративных предметах.", "Серебро" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Используется в современном оружии и доспехах.", "Титан" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Сплавляется для использования в различных оружейных изделиях.", "Молибден" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Применяется в различных металлических сплавах и покрытиях.", "Цинк" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Используется в легких оружиях и доспехах.", "Алюминий" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ценный металл, используется в украшениях.", "Платина" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Реже используется в ювелирных изделиях.", "Родий" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Драгоценный камень, использовался для украшений.", "Рубин" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 14, "Применяется в украшениях и декоративных элементах.", "Сапфир" },
                    { 15, "Драгоценный камень, используемый в ювелирных украшениях.", "Изумруд" },
                    { 16, "Ценный камень, использовался в орнаментах и украшениях.", "Алмаз" },
                    { 17, "Полудрагоценный камень, использовался в украшениях.", "Турмалин" },
                    { 18, "Драгоценный камень, применялся для ювелирных украшений.", "Лазурит" },
                    { 19, "Твердое дерево, использовалось в оружии и мебели.", "Дуб" },
                    { 20, "Древесина, применялась для мебели и аксессуаров.", "Орех" },
                    { 21, "Древесина для отделки мебели и декоративных изделий.", "Клен" },
                    { 22, "Используется для мебели и изделий для наружного применения.", "Лиственница" },
                    { 23, "Ценный вид древесины, используемый в мебели и аксессуарах.", "Махагон" },
                    { 24, "Твердое дерево, использовалось для производства мебели.", "Вишня" },
                    { 25, "Тик использовался в производстве мебели и для декоративных изделий.", "Тик" },
                    { 26, "Используется в производстве мебели и элементов интерьера.", "Кедр" },
                    { 27, "Шерстяные ткани использовались для производства одежды.", "Шерсть" },
                    { 28, "Льняные ткани использовались для одежды и тканей.", "Лён" },
                    { 29, "Ценный материал для тканей и аксессуаров.", "Шелк" },
                    { 30, "Шерсть для одежды и тканей, использовалась для одежды.", "Барс" },
                    { 31, "Мягкая шерсть, использовалась для тканей.", "Кашемир" },
                    { 32, "Деним использовался для одежды, в частности для джинсов.", "Деним" },
                    { 33, "Современный синтетический материал, использующийся в одежде и аксессуарах.", "Полиэстер" },
                    { 34, "Современный синтетический материал для декоративных элементов и сувениров.", "Пластик" },
                    { 35, "Используется для различных декоративных предметов.", "Стекло" },
                    { 36, "Керамика, используемая для посуды и сувениров.", "Фарфор" },
                    { 37, "Используются в украшениях и аксессуарах.", "Перья" },
                    { 38, "Используется для создания украшений и декоративных элементов.", "Рог" },
                    { 39, "Использовались для украшений и декоративных элементов.", "Кости" },
                    { 40, "Полудрагоценный камень, применяющийся для украшений.", "Гранат" },
                    { 41, "Используется для украшений и декоративных элементов.", "Коралл" },
                    { 42, "Камень, использующийся в строительстве и для декоративных элементов.", "Песчаник" },
                    { 43, "Используется для создания декоративных элементов и статуй.", "Гипс" },
                    { 44, "Применяются для создания посуды и декоративных элементов.", "Глиняные материалы" },
                    { 45, "Применяется в архитектуре, статуях и декоративных элементах.", "Мрамор" }
                });

            migrationBuilder.InsertData(
                table: "SouvenirTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Миниатюрные модели оружия" },
                    { 2, "Миниатюрные модели доспехов" },
                    { 3, "Модели щитов" },
                    { 4, "Реплики карт" },
                    { 5, "Исторические книги" },
                    { 6, "Реплики монет" },
                    { 7, "Памятные медали" },
                    { 8, "Реплики статуй" },
                    { 9, "Реплики сосудов" },
                    { 10, "Реплики мебели" },
                    { 11, "Кухонные принадлежности" },
                    { 12, "Реплики тканей" },
                    { 13, "Гобелены" },
                    { 14, "Реплики старинных часов" },
                    { 15, "Антикварные механизмы" },
                    { 16, "Ювелирные украшения" }
                });

            migrationBuilder.InsertData(
                table: "WeaponTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Мечи" },
                    { 2, "Кинжалы" },
                    { 3, "Топоры" },
                    { 4, "Булавы" },
                    { 5, "Копья" },
                    { 6, "Алебарды" },
                    { 7, "Луки" },
                    { 8, "Арбалеты" },
                    { 9, "Дротики" },
                    { 10, "Мушкеты" },
                    { 11, "Пистолеты" },
                    { 12, "Ружья" },
                    { 13, "Катаны" },
                    { 14, "Чакрамы" },
                    { 15, "Нунчаки" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponTypeId",
                table: "Weapons",
                column: "WeaponTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_ArmorTypeId",
                table: "Armors",
                column: "ArmorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_AccessoryTypeId",
                table: "Accessories",
                column: "AccessoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingType_ClothingTypeId",
                table: "ClothingType",
                column: "ClothingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Souvenirs_SouvenirTypeId",
                table: "Souvenirs",
                column: "SouvenirTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_AccessoryTypes_AccessoryTypeId",
                table: "Accessories",
                column: "AccessoryTypeId",
                principalTable: "AccessoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Armors_ArmorTypes_ArmorTypeId",
                table: "Armors",
                column: "ArmorTypeId",
                principalTable: "ArmorTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_WeaponTypes_WeaponTypeId",
                table: "Weapons",
                column: "WeaponTypeId",
                principalTable: "WeaponTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_AccessoryTypes_AccessoryTypeId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Armors_ArmorTypes_ArmorTypeId",
                table: "Armors");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_WeaponTypes_WeaponTypeId",
                table: "Weapons");

            migrationBuilder.DropTable(
                name: "AccessoryTypes");

            migrationBuilder.DropTable(
                name: "ArmorTypes");

            migrationBuilder.DropTable(
                name: "Clothings");

            migrationBuilder.DropTable(
                name: "ClothingType");

            migrationBuilder.DropTable(
                name: "Souvenirs");

            migrationBuilder.DropTable(
                name: "WeaponTypes");

            migrationBuilder.DropTable(
                name: "SouvenirTypes");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_WeaponTypeId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Armors_ArmorTypeId",
                table: "Armors");

            migrationBuilder.DropIndex(
                name: "IX_Accessories_AccessoryTypeId",
                table: "Accessories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DropColumn(
                name: "WeaponTypeId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ArmorTypeId",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "AccessoryTypeId",
                table: "Accessories");

            migrationBuilder.AddColumn<string>(
                name: "WeaponType",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArmorType",
                table: "Armors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccessoryType",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Одежда");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Книги");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Сувениры");

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Ренессанс");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Дерево (дуб)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Дерево (кедр)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Сталь, закаленная");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Железо, кованое");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Золото, 585 проба");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Серебро, 925 проба");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Кожа (натуральная, телячья)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Кожа (замша, натуральная)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Ткань (лен, грубый)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Ткань (шелк, китайский)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Керамика (майолика)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Керамика (фарфор, европейский)");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Мрамор, каррарский");
        }
    }
}
