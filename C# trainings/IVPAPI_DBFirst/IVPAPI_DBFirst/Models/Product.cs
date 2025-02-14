using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }
}
