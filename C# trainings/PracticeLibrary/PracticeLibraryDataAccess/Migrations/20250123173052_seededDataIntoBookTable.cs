using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeLibraryDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seededDataIntoBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BooksTest",
                columns: new[] { "BookID", "ISBN", "Price", "Title" },
                values: new object[] { 1, "1234ABC", 1000m, "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksTest",
                keyColumn: "BookID",
                keyValue: 1);
        }
    }
}
