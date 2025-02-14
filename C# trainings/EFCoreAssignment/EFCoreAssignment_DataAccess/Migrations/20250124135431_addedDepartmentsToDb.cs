using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedDepartmentsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "EFCoreAssignment",
                columns: table => new
                {
                    DEPARTMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPARTMENT_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MANAGER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DEPARTMENT_ID);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_MANAGER_ID",
                        column: x => x.MANAGER_ID,
                        principalSchema: "EFCoreAssignment",
                        principalTable: "Employees",
                        principalColumn: "EMPLOYEE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "DEPARTMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "MANAGER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Departments",
                column: "MANAGER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "DEPARTMENT_ID",
                principalSchema: "EFCoreAssignment",
                principalTable: "Departments",
                principalColumn: "DEPARTMENT_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "MANAGER_ID",
                principalSchema: "EFCoreAssignment",
                principalTable: "Employees",
                principalColumn: "EMPLOYEE_ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "EFCoreAssignment");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees");
        }
    }
}
