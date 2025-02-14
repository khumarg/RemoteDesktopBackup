using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class droppingForeignKeyManagerIDFromEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "MANAGER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "MANAGER_ID",
                principalSchema: "EFCoreAssignment",
                principalTable: "Employees",
                principalColumn: "EMPLOYEE_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
