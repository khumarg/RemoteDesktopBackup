﻿using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class Job
{
    public string JobId { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public int? MinSalary { get; set; }

    public int? MaxSalary { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
