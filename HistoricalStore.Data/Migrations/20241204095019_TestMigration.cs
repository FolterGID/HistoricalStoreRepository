using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HistoricalStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Древний мир");

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Античность");

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Средневековье");

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Ренессанс");

            migrationBuilder.InsertData(
                table: "HistoricalPeriods",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Новое время" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Античность");

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Средневековье");

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Ренессанс");

            migrationBuilder.UpdateData(
                table: "HistoricalPeriods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Новое время");
        }
    }
}
