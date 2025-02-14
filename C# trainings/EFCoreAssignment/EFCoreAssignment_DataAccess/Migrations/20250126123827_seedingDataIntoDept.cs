using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedingDataIntoDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                schema: "EFCoreAssignment",
                table: "Departments",
                columns: new[] { "DEPARTMENT_ID", "DEPARTMENT_NAME", "MANAGER_ID" },
                values: new object[,]
                {
                    { 90, "Executive", 100 },
                    { 100, "Finance", 108 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EFCoreAssignment",
                table: "Departments",
                keyColumn: "DEPARTMENT_ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "EFCoreAssignment",
                table: "Departments",
                keyColumn: "DEPARTMENT_ID",
                keyValue: 100);

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
    }
}
