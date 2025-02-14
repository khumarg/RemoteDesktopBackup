using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IVPLibrary_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedCheckConstraintOnPriceInBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "Books_Price_CK",
                table: "Books",
                sql: "Price > 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Books_Price_CK",
                table: "Books");
        }
    }
}
