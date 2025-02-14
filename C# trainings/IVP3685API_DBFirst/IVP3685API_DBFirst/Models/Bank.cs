using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class Bank
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public string? AccType { get; set; }

    public double? Balance { get; set; }

    public string Country { get; set; } = null!;
}
