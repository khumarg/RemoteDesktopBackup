using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedingDataIntoEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "EFCoreAssignment",
                table: "Employees",
                columns: new[] { "EMPLOYEE_ID", "COMMISSION_PCT", "DEPARTMENT_ID", "EMAIL", "FIRST_NAME", "HIRE_DATE", "JOB_ID", "LAST_NAME", "MANAGER_ID", "PHONE_NUMBER", "SALARY" },
                values: new object[,]
                {
                    { 100, 0.10000000000000001, 90, "SKING", "Steven", new DateTime(2025, 1, 27, 18, 51, 39, 785, DateTimeKind.Local).AddTicks(9491), "AC_ACCOUNT", "King", 0, "515.123.4567", 24000.0 },
                    { 108, 0.20000000000000001, 100, "NKOCHHAR", "Neena", new DateTime(2025, 1, 27, 18, 51, 39, 785, DateTimeKind.Local).AddTicks(9501), "AC_MGR", "Kochhar", 0, "515.123.4568", 17000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EFCoreAssignment",
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "EFCoreAssignment",
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 108);
        }
    }
}
