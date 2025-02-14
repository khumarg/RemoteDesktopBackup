using System;
using System.Collections.Generic;

namespace AppleApp.Models;

public partial class Bank
{
    public int Cid { get; set; }

    public string? Cname { get; set; }

    public double? Balance { get; set; }
}
