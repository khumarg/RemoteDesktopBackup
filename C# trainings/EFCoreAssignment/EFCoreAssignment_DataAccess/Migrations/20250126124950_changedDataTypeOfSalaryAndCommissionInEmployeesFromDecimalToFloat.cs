using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changedDataTypeOfSalaryAndCommissionInEmployeesFromDecimalToFloat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<float>(
                name: "SALARY",
                schema: "EFCoreAssignment",
                table: "Employees",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "COMMISSION_PCT",
                schema: "EFCoreAssignment",
                table: "Employees",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Departments",
                column: "MANAGER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Departments",
                column: "MANAGER_ID",
                principalSchema: "EFCoreAssignment",
                principalTable: "Employees",
                principalColumn: "EMPLOYEE_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Departments");

            migrationBuilder.AlterColumn<decimal>(
                name: "SALARY",
                schema: "EFCoreAssignment",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "COMMISSION_PCT",
                schema: "EFCoreAssignment",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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
    }
}
