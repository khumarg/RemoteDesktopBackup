using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IVPLibrary_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "12B45", 1200.34m, ".NET Framework" },
                    { 2, "72B45", 1500.99m, "SQL Server" },
                    { 3, "00B45", 1000.34m, "Oracle" },
                    { 4, "99B45", 2000.99m, "Java" },
                    { 5, "34B45", 3000.99m, "ReactJS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 5);
        }
    }
}
