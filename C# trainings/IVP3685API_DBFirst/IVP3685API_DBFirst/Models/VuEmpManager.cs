using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class VuEmpManager
{
    public string? WorkerName { get; set; }

    public double? WorkerSalary { get; set; }

    public string? ManagerName { get; set; }

    public int ManagerId { get; set; }
}
