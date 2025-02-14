using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class BookDetail
{
    public int BookDetailsId { get; set; }

    public int NumberOfChapters { get; set; }

    public int NumberOfPages { get; set; }

    public string? Weight { get; set; }
}
