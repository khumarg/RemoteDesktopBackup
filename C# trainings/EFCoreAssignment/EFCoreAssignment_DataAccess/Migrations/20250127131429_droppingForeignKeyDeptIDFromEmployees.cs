using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class droppingForeignKeyDeptIDFromEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "DEPARTMENT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "DEPARTMENT_ID",
                principalSchema: "EFCoreAssignment",
                principalTable: "Departments",
                principalColumn: "DEPARTMENT_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
