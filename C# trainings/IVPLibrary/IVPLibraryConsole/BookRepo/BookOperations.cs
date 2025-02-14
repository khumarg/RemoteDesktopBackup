using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVPLibrary_DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace IVPLibraryConsole.BookRepo
{
    internal class BookOperations : IBook
    {
        public async Task FetchAllBooks()
        {
            using var context = new ApplicationDBContext();
            var books = await context.Books.ToListAsync();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.BookID} - {book.Title} - {book.Price} - {book.Publisher_Id}");
            }
        }
    }
}
