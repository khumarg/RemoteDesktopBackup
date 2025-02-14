using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dropForeignKeyManagersFromDeptTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
