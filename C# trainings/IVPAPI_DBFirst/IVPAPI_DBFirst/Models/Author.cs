using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual ICollection<Book> BooksBooks { get; set; } = new List<Book>();
}
