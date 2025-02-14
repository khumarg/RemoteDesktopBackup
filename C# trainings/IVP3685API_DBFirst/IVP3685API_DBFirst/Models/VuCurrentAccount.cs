using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class VuCurrentAccount
{
    public int Cid { get; set; }

    public string? AccType { get; set; }

    public double? Balance { get; set; }
}
