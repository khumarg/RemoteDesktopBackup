using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedEmployeeDetailsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                schema: "EFCoreAssignment",
                columns: table => new
                {
                    EmployeeDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aadhaar = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    EMPLOYEE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.EmployeeDetailsID);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Employees_EMPLOYEE_ID",
                        column: x => x.EMPLOYEE_ID,
                        principalSchema: "EFCoreAssignment",
                        principalTable: "Employees",
                        principalColumn: "EMPLOYEE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_Aadhaar",
                schema: "EFCoreAssignment",
                table: "EmployeeDetails",
                column: "Aadhaar",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_EMPLOYEE_ID",
                schema: "EFCoreAssignment",
                table: "EmployeeDetails",
                column: "EMPLOYEE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails",
                schema: "EFCoreAssignment");
        }
    }
}
