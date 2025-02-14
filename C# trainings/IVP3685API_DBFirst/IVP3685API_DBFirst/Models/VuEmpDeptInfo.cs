using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class VuEmpDeptInfo
{
    public string DeptName { get; set; } = null!;

    public int? NoOfEmployees { get; set; }

    public double? TotalSalary { get; set; }

    public double? AverageSalary { get; set; }
}
