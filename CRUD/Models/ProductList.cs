﻿using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class ProductList
{
    public int Pid { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public string ProductFile { get; set; } = null!;

    public decimal Quantity { get; set; }

    public decimal Rate { get; set; }
}
