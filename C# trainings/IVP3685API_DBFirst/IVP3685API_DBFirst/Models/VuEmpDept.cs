using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class VuEmpDept
{
    public int EmployeeId { get; set; }

    public string? EmpName { get; set; }

    public double? Salary { get; set; }

    public string JobId { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}
