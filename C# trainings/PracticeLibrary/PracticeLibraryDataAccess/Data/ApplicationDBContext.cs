using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeLibraryModels.Models;

namespace PracticeLibraryDataAccess.Data
{
    internal class ApplicationDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=192.168.0.13\\sqlexpress,49753; Database = IVPLibrary_3685; User Id = sa; Password = sa@12345678; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    BookID = 1,
                    Title = "Test",
                    Price = 1000,
                    ISBN = "1234ABC"
                }
            );
        }
    }
}
