using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class BooksTest
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public decimal Price { get; set; }
}
