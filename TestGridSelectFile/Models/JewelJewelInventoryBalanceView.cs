using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class JewelJewelInventoryBalanceView
{
    public int Id { get; set; }

    public string? Jewel { get; set; }

    public string? JewelSize { get; set; }

    public int? Quantity { get; set; }

    public double? Carat { get; set; }
}
