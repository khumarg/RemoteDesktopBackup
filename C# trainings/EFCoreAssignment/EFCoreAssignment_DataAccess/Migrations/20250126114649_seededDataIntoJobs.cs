using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seededDataIntoJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "EFCoreAssignment",
                table: "Jobs",
                columns: new[] { "JOB_ID", "JOB_TITLE", "MAX_SALARY", "MIN_SALARY" },
                values: new object[,]
                {
                    { "AC_ACCOUNT", "Public Accountant", 4200, 9000 },
                    { "AC_MGR", "Accounting Manager", 8200, 8200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EFCoreAssignment",
                table: "Jobs",
                keyColumn: "JOB_ID",
                keyValue: "AC_ACCOUNT");

            migrationBuilder.DeleteData(
                schema: "EFCoreAssignment",
                table: "Jobs",
                keyColumn: "JOB_ID",
                keyValue: "AC_MGR");
        }
    }
}
