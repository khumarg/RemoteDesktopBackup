using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVPLibrary_DataAccess.Data;
using IVPLibrary_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace IVPLibraryConsole
{
    internal class CRUD_IVPLibrary
    {
        public async Task CRUD()
        {
            ApplicationDBContext context = new ApplicationDBContext();

            context.Database.EnsureCreated();

            //if(context.Database.GetPendingMigrations().Count() > 0)
            //{
            //    //context.Database.Migrate();
            //    Console.WriteLine(context.Database.GetPendingMigrations().Count());
            //}

            //Books book = new Books()
            //{
            //    Title = "Git",
            //    Price = 1234.00m,
            //    ISBN = "56K67",
            //    Publisher_Id = 2
            //};

            //INSERTION INTO TABLE
            //context.Books.Add(book);
            //context.SaveChanges();

            // DEFERRED EXECUTION

            //var blist = context.Books.OrderBy(x => x.Publisher_Id).ThenByDescending(x => x.Price);

            //foreach ( var book in blist )
            //{
            //    Console.WriteLine($"{book.BookID} - {book.Title} - {book.Price} - {book.Publisher_Id}");
            //}

            // UPDATE DATA IN TABLE

            //var book = context.Books.Find(6);
            //book.ISBN = "90B09";
            //context.SaveChanges();

            //Console.WriteLine($"{book.BookID} - {book.Title} - {book.Price} - {book.ISBN} - {book.Publisher_Id}");

            var books = context.Books.Where(x => x.Price > 2000);

            foreach(var item in books)
            {
                item.Price = item.Price * 1.20m;
            }

            await context.SaveChangesAsync();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.BookID} - {book.Title} - {book.Price} - {book.Publisher_Id}");
            }

            //FETCH DATA FROM TABLE

            //var books = context.Books.Where(x => x.Price > 1500).OrderByDescending(x => x.Title);

            //var books = context.Books.Skip(0).Take(5);
            //var books = context.Books.Skip(2).Take(3);

            // Deleting Single Record
            //var book1 = context.Books.Find(5);
            //context.Books.Remove(book1);
            //context.SaveChanges();


            // Deleting Multiple Records
            //var data = context.Books.Where(x => x.Publisher_Id == 3);

            //foreach (var item in data)
            //{
            //    context.Books.Remove(item);
            //}

            //context.SaveChanges();

            //var books = context.Books;

            ////var books = context.Books.Where(x => x.Publisher_Id == 2).Skip(0).Take(5).OrderByDescending(x => x.Title);

            //foreach (var book in books)
            //{
            //    Console.WriteLine($"{book.BookID} - {book.Title} - {book.Price} - {book.Publisher_Id}");
            //}

            //var blist = context.Books.Where(x => x.ISBN.Contains("0"));

            //var blist = context.Books.Where(x => EF.Functions.Like(x.Title, "S%"));

            //var blist = context.Books.Where(x => EF.Functions.Like(x.Title, "%r"));

            //var blist = context.Books.Where(x => EF.Functions.Like(x.Title, "_a%"));

            //var blist = context.Books.Where(x => EF.Functions.Like(x.Title, "[A-N]%"));

            //var blist = context.Books.Where(x => EF.Functions.Like(x.ISBN, "_2%")).Max(x => x.Price);

            //var x1 = context.Books.Sum(x => x.Price);

            //Console.WriteLine("Total Price = " + x1);


            //foreach (var book in blist)
            //{
            //    Console.WriteLine($"{book.BookID} - {book.Title} - {book.ISBN} - {book.Price} - {book.Publisher_Id}");
            //}

            //var b = context.Books.Find(5);

            //var b = context.Books.Single(x => x.ISBN == "99B45");

            //var b = context.Books.SingleOrDefault(x => x.Publisher_Id == 100);

            //var b = context.Books.FirstOrDefault(x => x.Publisher_Id == 3);

            //var b = context.Books.Where(x => x.Publisher_Id == 3).FirstOrDefault();

            //Console.WriteLine($"{b.BookID} - {b.Title} - {b.ISBN} - {b.Price} - {b.Publisher_Id}");

            //var blist = context.Books.Where(x => x.Price > 1500 || x.Publisher_Id == 2);

            //var blist = context.Books.Where(x => x.Price > 1500);

            //var blist = context.Books.Where(x => x.Publisher_Id == 3);

            //foreach (var book in blist)
            //{
            //    Console.WriteLine($"{book.BookID} - {book.Title} - {book.ISBN} - {book.Price} - {book.Publisher_Id}");
            //}

            //var info = context.Books.First();
            //var info = context.Books.FirstOrDefault();
            //Console.WriteLine($"{info.BookID} - {info.Title} - {info.ISBN} - {info.Price}");

            //var authorInfo = context.Authors.FirstOrDefault();

            //var booksList = context.Books.ToList();

            //foreach ( var b in booksList )
            //{
            //    Console.WriteLine($"{b.BookID} - {b.Title} - {b.ISBN} - {b.Price}");
            //}

            //var publisherList = context.publishers.ToList();

            //foreach (var publisher in publisherList)
            //{
            //    Console.WriteLine($"{publisher.Publisher_Id} - {publisher.Name} - {publisher.Location}");
            //}
        }
    }
}
