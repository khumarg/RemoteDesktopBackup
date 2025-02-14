using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class AuditBank
{
    public string? Username { get; set; }

    public DateTime? XnDate { get; set; }

    public string? NewAccType { get; set; }

    public string? OldAccType { get; set; }

    public double? NewBalance { get; set; }

    public double? OldBalance { get; set; }

    public string? XnType { get; set; }

    public int? Cid { get; set; }
}
