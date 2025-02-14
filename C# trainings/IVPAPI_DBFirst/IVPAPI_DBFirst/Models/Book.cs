using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public decimal Price { get; set; }

    public int PublisherId { get; set; }

    public virtual Publisher Publisher { get; set; } = null!;

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<Author> AuthorsNavigation { get; set; } = new List<Author>();
}
