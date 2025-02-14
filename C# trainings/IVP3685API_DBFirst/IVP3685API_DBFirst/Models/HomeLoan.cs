using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class HomeLoan
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public string? LoanType { get; set; }

    public double? Amount { get; set; }
}
