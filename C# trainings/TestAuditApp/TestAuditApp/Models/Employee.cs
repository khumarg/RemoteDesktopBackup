using System;
using System.Collections.Generic;

namespace TestAuditApp.Models;

public partial class Employee
{
    public int Eid { get; set; }

    public string? Name { get; set; }

    public int? Salary { get; set; }
}
