using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpModels.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpDataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=192.168.0.13\\sqlexpress,49753; Database = HRDB_3685; User Id = sa; Password = sa@12345678; TrustServerCertificate = True");
        }
    }
}
