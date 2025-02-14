using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class VuStudentDetail
{
    public int Sid { get; set; }

    public string StudentName { get; set; } = null!;

    public string? Email { get; set; }

    public string StreamName { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string Hodname { get; set; } = null!;

    public DateTime AdmissionDate { get; set; }
}
