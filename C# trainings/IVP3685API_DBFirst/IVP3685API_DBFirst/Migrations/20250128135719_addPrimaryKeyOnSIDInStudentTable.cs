using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IVP3685API_DBFirst.Migrations
{
    /// <inheritdoc />
    public partial class addPrimaryKeyOnSIDInStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MinProj");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.CreateTable(
                name: "Administrator",
                schema: "MinProj",
                columns: table => new
                {
                    AdminID = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    AdminName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AdminContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AdminEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Administ__719FE4E87D06FF84", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "AuditBank",
                columns: table => new
                {
                    Username = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    XnDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NewAccType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    OldAccType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NewBalance = table.Column<double>(type: "float", nullable: true),
                    OldBalance = table.Column<double>(type: "float", nullable: true),
                    XnType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AccType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    Country = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "India")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bank__C1F8DC59E74D2FE1", x => x.CID);
                });

            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CardType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CreditCa__C1F8DC591879723F", x => x.CID);
                });

            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    DID = table.Column<int>(type: "int", nullable: false),
                    DName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dept__C0365630C484C6D9", x => x.DID);
                });

            migrationBuilder.CreateTable(
                name: "grpA",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__grpA__123AE7B920D7ACD0", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "grpB",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__grpB__123AE7B9F26CA441", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "HomeLoan",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LoanType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HomeLoan__C1F8DC59D64876CC", x => x.CID);
                });

            migrationBuilder.CreateTable(
                name: "JOBS",
                columns: table => new
                {
                    JOB_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JOB_TITLE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MIN_SALARY = table.Column<int>(type: "int", nullable: true),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("JOBS_ID_PK", x => x.JOB_ID);
                });

            migrationBuilder.CreateTable(
                name: "NewBank",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AccType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    Country = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Prod_Bank",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AccType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false),
                    PName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    PCategory = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Sales",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false),
                    PName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__C57755209A582938", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "STDBANK",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AccType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    Country = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("STDBANK_PK", x => x.CID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Stream",
                schema: "MinProj",
                columns: table => new
                {
                    StreamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreamName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stream__07C87AB2212F0503", x => x.StreamID);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    SID = table.Column<int>(type: "int", nullable: false),
                    SName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Branch = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Marks = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    EID = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    Email = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AdharCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Country = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: "India"),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DID = table.Column<int>(type: "int", nullable: true),
                    MID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Emp_EID_PK", x => x.EID);
                    table.ForeignKey(
                        name: "Emp_DID_FK",
                        column: x => x.DID,
                        principalTable: "Dept",
                        principalColumn: "DID");
                    table.ForeignKey(
                        name: "Emp_MID_FK",
                        column: x => x.MID,
                        principalTable: "Emp",
                        principalColumn: "EID");
                });

            migrationBuilder.CreateTable(
                name: "HOD",
                schema: "MinProj",
                columns: table => new
                {
                    HODID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    StreamID = table.Column<int>(type: "int", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOD__402E7AE593F32CAA", x => x.HODID);
                    table.ForeignKey(
                        name: "FK__HOD__StreamID__3D2915A8",
                        column: x => x.StreamID,
                        principalSchema: "MinProj",
                        principalTable: "Stream",
                        principalColumn: "StreamID");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "MinProj",
                columns: table => new
                {
                    SID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StreamID = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Marks = table.Column<double>(type: "float", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Student__CA195970A9478EEE", x => x.SID);
                    table.ForeignKey(
                        name: "FK__Student__StreamI__37703C52",
                        column: x => x.StreamID,
                        principalSchema: "MinProj",
                        principalTable: "Stream",
                        principalColumn: "StreamID");
                });

            migrationBuilder.CreateTable(
                name: "DEPARTMENTS",
                columns: table => new
                {
                    DEPARTMENT_ID = table.Column<int>(type: "int", nullable: false),
                    DEPARTMENT_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MANAGER_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DEPT_ID_PK", x => x.DEPARTMENT_ID);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEES",
                columns: table => new
                {
                    EMPLOYEE_ID = table.Column<int>(type: "int", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    LAST_NAME = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PHONE_NUMBER = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    HIRE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    JOB_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SALARY = table.Column<double>(type: "float", nullable: true),
                    COMMISSION_PCT = table.Column<double>(type: "float", nullable: true),
                    MANAGER_ID = table.Column<int>(type: "int", nullable: true),
                    DEPARTMENT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("EMP_EMP_ID_PK", x => x.EMPLOYEE_ID);
                    table.ForeignKey(
                        name: "EMP_DEPT_FK",
                        column: x => x.DEPARTMENT_ID,
                        principalTable: "DEPARTMENTS",
                        principalColumn: "DEPARTMENT_ID");
                    table.ForeignKey(
                        name: "EMP_JOB_FK",
                        column: x => x.JOB_ID,
                        principalTable: "JOBS",
                        principalColumn: "JOB_ID");
                    table.ForeignKey(
                        name: "EMP_MANAGER_FK",
                        column: x => x.MANAGER_ID,
                        principalTable: "EMPLOYEES",
                        principalColumn: "EMPLOYEE_ID");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Administ__1788CCAD22EA0EAB",
                schema: "MinProj",
                table: "Administrator",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Administ__8286ECDC8685F11B",
                schema: "MinProj",
                table: "Administrator",
                column: "AdminContact",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Administ__F2AA7AD91608B908",
                schema: "MinProj",
                table: "Administrator",
                column: "AdminEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEPARTMENTS_MANAGER_ID",
                table: "DEPARTMENTS",
                column: "MANAGER_ID");

            migrationBuilder.CreateIndex(
                name: "Emp_AC_UK",
                table: "Emp",
                column: "AdharCard",
                unique: true,
                filter: "[AdharCard] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "Emp_mail_UK",
                table: "Emp",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Emp_DID",
                table: "Emp",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_Emp_MID",
                table: "Emp",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "EMP_EMAIL_UK",
                table: "EMPLOYEES",
                column: "EMAIL",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EMPLOYEES_DEPARTMENT_ID_NCI",
                table: "EMPLOYEES",
                column: "DEPARTMENT_ID");

            migrationBuilder.CreateIndex(
                name: "employees_FIDX",
                table: "EMPLOYEES",
                column: "EMPLOYEE_ID",
                filter: "([COMMISSION_PCT] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "employees_UCI",
                table: "EMPLOYEES",
                columns: new[] { "LAST_NAME", "JOB_ID", "HIRE_DATE" });

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEES_JOB_ID",
                table: "EMPLOYEES",
                column: "JOB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEES_MANAGER_ID",
                table: "EMPLOYEES",
                column: "MANAGER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HOD_StreamID",
                schema: "MinProj",
                table: "HOD",
                column: "StreamID");

            migrationBuilder.CreateIndex(
                name: "UQ__HOD__A9D10534ABF009C5",
                schema: "MinProj",
                table: "HOD",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "Product_PCat_NCI",
                table: "Product",
                column: "PCategory");

            migrationBuilder.CreateIndex(
                name: "Student_Branch_Marks_NCI",
                table: "student",
                columns: new[] { "Branch", "Marks" });

            migrationBuilder.CreateIndex(
                name: "Student_Branch_NCI",
                table: "student",
                column: "Branch");

            migrationBuilder.CreateIndex(
                name: "Student_Marks_NCI",
                table: "student",
                column: "Marks");

            migrationBuilder.CreateIndex(
                name: "Student_SID_UCI",
                table: "student",
                column: "SID",
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "Student_SName_Marks_NCI",
                table: "student",
                columns: new[] { "SName", "Marks" });

            migrationBuilder.CreateIndex(
                name: "Student_SName_NCI",
                table: "student",
                column: "SName");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StreamID",
                schema: "MinProj",
                table: "Student",
                column: "StreamID");

            migrationBuilder.CreateIndex(
                name: "UQ__Student__A9D1053490CF5F48",
                schema: "MinProj",
                table: "Student",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "DEPT_MGR_FK",
                table: "DEPARTMENTS",
                column: "MANAGER_ID",
                principalTable: "EMPLOYEES",
                principalColumn: "EMPLOYEE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "DEPT_MGR_FK",
                table: "DEPARTMENTS");

            migrationBuilder.DropTable(
                name: "Administrator",
                schema: "MinProj");

            migrationBuilder.DropTable(
                name: "AuditBank");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "CreditCard");

            migrationBuilder.DropTable(
                name: "Emp");

            migrationBuilder.DropTable(
                name: "grpA");

            migrationBuilder.DropTable(
                name: "grpB");

            migrationBuilder.DropTable(
                name: "HOD",
                schema: "MinProj");

            migrationBuilder.DropTable(
                name: "HomeLoan");

            migrationBuilder.DropTable(
                name: "NewBank");

            migrationBuilder.DropTable(
                name: "Prod_Bank");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "STDBANK");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "MinProj");

            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "Stream",
                schema: "MinProj");

            migrationBuilder.DropTable(
                name: "EMPLOYEES");

            migrationBuilder.DropTable(
                name: "DEPARTMENTS");

            migrationBuilder.DropTable(
                name: "JOBS");
        }
    }
}
