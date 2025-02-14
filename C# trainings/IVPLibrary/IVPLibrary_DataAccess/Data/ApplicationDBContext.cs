using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IVPLibrary_Models.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Logging;

namespace IVPLibrary_DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> publishers { get; set; } 
        public DbSet<SubCategory> SubCategories { get; set; } 
        public DbSet<BookDetails> BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=192.168.0.13\\sqlexpress,49753; Database = IVPLibrary_3685; User Id = sa; Password = sa@12345678; TrustServerCertificate = True;").LogTo(Console.WriteLine, new[]
            {
                DbLoggerCategory.Database.Command.Name
            }, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Books>().Property(x => x.Price).HasPrecision(10, 5);

            // Seeding Data into Books
            model.Entity<Books>().HasData(
                    new Books()
                    {
                        BookID = 1,
                        Title = ".NET Framework",
                        ISBN = "12B45",
                        Price = 1200.34m,
                        Publisher_Id = 1
                    },
                    new Books()
                    {
                        BookID = 2,
                        Title = "SQL Server",
                        ISBN = "72B45",
                        Price = 1500.99m,
                        Publisher_Id = 1
                    }
                );

            var booklist = new Books[]
            {
                new Books() { BookID = 3, Title = "Oracle", ISBN="00B45", Price=1000.34m, Publisher_Id = 2 },
                new Books() { BookID = 4, Title = "Java", ISBN = "99B45", Price = 2000.99m, Publisher_Id = 3 },
                new Books() { BookID = 5, Title = "ReactJS", ISBN = "34B45", Price = 3000.99m, Publisher_Id = 3 },
            };

            model.Entity<Books>().HasData(booklist);

            model.Entity<Books>().ToTable(x => x.HasCheckConstraint("Books_Price_CK", "Price > 0"));

            // Primary Key
            model.Entity<Product>().HasKey(x => x.ProductID);

            // Table Name
            model.Entity<Product>().ToTable("Products");

            // Column Name
            model.Entity<Product>().Property(x => x.ProductName).HasColumnName("Name");

            // Required
            model.Entity<Product>().Property(x => x.ProductName).IsRequired();

            // Not Mapped
            model.Entity<Product>().Ignore(x => x.Discount);

            // Maximum Length
            model.Entity<Product>().Property(x => x.ProductName).HasMaxLength(50);

            // Check Constraint on Price
            model.Entity<Product>().ToTable(x => x.HasCheckConstraint("Product_Price_CK", "Price > 0"));


            // Seeding data into Publisher
            model.Entity<Publisher>().HasData(
                    new Publisher() { Publisher_Id = 1, Name = "IVP Publisher", Location = "Delhi" },
                    new Publisher() { Publisher_Id = 2, Name = "AYT Publisher", Location = "Mumbai" },
                    new Publisher() { Publisher_Id = 3, Name = "Hedge Publisher", Location = "Bangalore" }
                );

            model.Entity<BookAuthorMap>().HasKey(x => new { x.Author_Id, x.BookID });
        }
    }
}
