using System;
using System.Collections.Generic;

namespace IVP3685API_DBFirst.Models;

public partial class Stream
{
    public int StreamId { get; set; }

    public string StreamName { get; set; } = null!;

    public virtual ICollection<Hod> Hods { get; set; } = new List<Hod>();

    public virtual ICollection<Student1> Student1s { get; set; } = new List<Student1>();
}
