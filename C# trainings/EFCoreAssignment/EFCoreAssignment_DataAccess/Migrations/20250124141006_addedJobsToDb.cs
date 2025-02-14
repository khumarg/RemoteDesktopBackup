using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedJobsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JOB_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Jobs",
                schema: "EFCoreAssignment",
                columns: table => new
                {
                    JOB_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JOB_TITLE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MIN_SALARY = table.Column<int>(type: "int", nullable: false),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JOB_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JOB_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "JOB_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_JOB_ID",
                schema: "EFCoreAssignment",
                table: "Employees",
                column: "JOB_ID",
                principalSchema: "EFCoreAssignment",
                principalTable: "Jobs",
                principalColumn: "JOB_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_JOB_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Jobs",
                schema: "EFCoreAssignment");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JOB_ID",
                schema: "EFCoreAssignment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JOB_ID",
                schema: "EFCoreAssignment",
                table: "Employees");
        }
    }
}
