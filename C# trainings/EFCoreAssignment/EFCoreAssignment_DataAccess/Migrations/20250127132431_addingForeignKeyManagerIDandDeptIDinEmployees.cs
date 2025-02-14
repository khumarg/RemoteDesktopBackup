using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addingForeignKeyManagerIDandDeptIDinEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "EFCoreAssignment",
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 100,
                column: "HIRE_DATE",
                value: new DateTime(2025, 1, 27, 18, 54, 31, 622, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                schema: "EFCoreAssignment",
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 108,
                column: "HIRE_DATE",
                value: new DateTime(2025, 1, 27, 18, 54, 31, 622, DateTimeKind.Local).AddTicks(5174));

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

            migrationBuilder.DropIndex(
                name: "IX_Employees_DEPARTMENT_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MANAGER_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.UpdateData(
                schema: "EFCoreAssignment",
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 100,
                column: "HIRE_DATE",
                value: new DateTime(2025, 1, 27, 18, 51, 39, 785, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                schema: "EFCoreAssignment",
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 108,
                column: "HIRE_DATE",
                value: new DateTime(2025, 1, 27, 18, 51, 39, 785, DateTimeKind.Local).AddTicks(9501));
        }
    }
}
