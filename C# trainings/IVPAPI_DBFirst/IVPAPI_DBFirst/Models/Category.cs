﻿using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;
}
