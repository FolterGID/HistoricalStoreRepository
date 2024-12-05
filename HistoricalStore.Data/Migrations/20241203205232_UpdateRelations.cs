using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricalStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductHistoricalPeriods");

            migrationBuilder.DropTable(
                name: "ProductMaterials");

            migrationBuilder.CreateTable(
                name: "HistoricalPeriodProduct",
                columns: table => new
                {
                    HistoricalPeriodsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalPeriodProduct", x => new { x.HistoricalPeriodsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_HistoricalPeriodProduct_HistoricalPeriods_HistoricalPeriodsId",
                        column: x => x.HistoricalPeriodsId,
                        principalTable: "HistoricalPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricalPeriodProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialProduct",
                columns: table => new
                {
                    MaterialsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialProduct", x => new { x.MaterialsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_MaterialProduct_Materials_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalPeriodProduct_ProductsId",
                table: "HistoricalPeriodProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialProduct_ProductsId",
                table: "MaterialProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricalPeriodProduct");

            migrationBuilder.DropTable(
                name: "MaterialProduct");

            migrationBuilder.CreateTable(
                name: "ProductHistoricalPeriods",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    HistoricalPeriodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductHistoricalPeriods", x => new { x.ProductId, x.HistoricalPeriodId });
                    table.ForeignKey(
                        name: "FK_ProductHistoricalPeriods_HistoricalPeriods_HistoricalPeriodId",
                        column: x => x.HistoricalPeriodId,
                        principalTable: "HistoricalPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductHistoricalPeriods_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterials",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterials", x => new { x.ProductId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductHistoricalPeriods_HistoricalPeriodId",
                table: "ProductHistoricalPeriods",
                column: "HistoricalPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_MaterialId",
                table: "ProductMaterials",
                column: "MaterialId");
        }
    }
}
