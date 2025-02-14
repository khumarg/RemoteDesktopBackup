using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedEmployeesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EFCoreAssignment");

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "EFCoreAssignment",
                columns: table => new
                {
                    EMPLOYEE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LAST_NAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PHONE_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIRE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SALARY = table.Column<float>(type: "real", nullable: false),
                    COMMISSION_PCT = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EMPLOYEE_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees",
                schema: "EFCoreAssignment");
        }
    }
}
