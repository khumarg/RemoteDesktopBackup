using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class CreditCard
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public string? CardType { get; set; }

    public double? Amount { get; set; }
}
