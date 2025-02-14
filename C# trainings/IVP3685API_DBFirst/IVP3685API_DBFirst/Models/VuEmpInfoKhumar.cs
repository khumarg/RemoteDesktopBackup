using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class VuEmpInfoKhumar
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public double? Salary { get; set; }

    public double? Tax { get; set; }

    public string JobId { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public int? Year { get; set; }

    public int? DepartmentId { get; set; }

    public string? HireMonth { get; set; }

    public int? Exp { get; set; }
}
