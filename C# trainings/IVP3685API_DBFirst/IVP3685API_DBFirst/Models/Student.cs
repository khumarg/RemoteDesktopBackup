using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IVP3685API_DBFirst.Models;

public partial class Student
{
    [Key]
    public int Sid { get; set; }

    public string Sname { get; set; } = null!;

    public string? Branch { get; set; }

    public double? Marks { get; set; }
}
