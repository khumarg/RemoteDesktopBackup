﻿using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Bank
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public double? Balance { get; set; }
}
