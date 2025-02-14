using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
