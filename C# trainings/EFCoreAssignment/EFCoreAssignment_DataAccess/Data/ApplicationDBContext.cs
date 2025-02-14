using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment_DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<EmployeeDetails> EmployeesDetails { get; set; }
        public DbSet<Projects> Projects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=192.168.0.13\\sqlexpress,49753; Database = EFCoreAssignment_3685; User Id = sa; Password = sa@12345678; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            ApplicationDBContext context = new ApplicationDBContext();

            model.Entity<EmployeeDetails>().HasIndex(x => x.Aadhaar).IsUnique();

            model.Entity<EmployeeProjects>().HasKey(x => new { x.EMPLOYEE_ID, x.ProjectID });

            //model.Entity<Department>().Property(x => x.DEPARTMENT_ID).ValueGeneratedNever();

            var empList = new Employee[]
            {
                new Employee() { EMPLOYEE_ID = 100, FIRST_NAME = "Steven", LAST_NAME = "King", EMAIL = "SKING",
                                PHONE_NUMBER = "515.123.4567", HIRE_DATE = DateTime.Now, SALARY = 24000f, COMMISSION_PCT = 0.1, DEPARTMENT_ID = 90, JOB_ID = "AC_ACCOUNT" },
                new Employee() { EMPLOYEE_ID = 108, FIRST_NAME = "Neena", LAST_NAME = "Kochhar", EMAIL = "NKOCHHAR",
                                PHONE_NUMBER = "515.123.4568", HIRE_DATE = DateTime.Now, SALARY = 17000f, COMMISSION_PCT = 0.2, DEPARTMENT_ID = 100,  JOB_ID = "AC_MGR" }
            };

            model.Entity<Employee>().HasData(empList);

            //var deptList = new Department[]
            //{
            //    new Department() { DEPARTMENT_ID = 90, DEPARTMENT_NAME = "Executive", MANAGER_ID = 100 },
            //    new Department() { DEPARTMENT_ID = 100, DEPARTMENT_NAME = "Finance", MANAGER_ID = 108 }
            //};

            //model.Entity<Department>().HasData(deptList);

            //var jobList = new Jobs[]
            //{
            //    new Jobs() { JOB_ID = "AC_ACCOUNT", JOB_TITLE = "Public Accountant", MAX_SALARY = 4200, MIN_SALARY = 9000 },
            //    new Jobs() { JOB_ID = "AC_MGR", JOB_TITLE = "Accounting Manager", MAX_SALARY = 8200, MIN_SALARY = 8200 }
            //};

            //model.Entity<Jobs>().HasData(jobList);
        }
    }
}
