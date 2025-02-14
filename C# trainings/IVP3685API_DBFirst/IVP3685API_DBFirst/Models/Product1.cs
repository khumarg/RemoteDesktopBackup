using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class Product1
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public double? Price { get; set; }
}
