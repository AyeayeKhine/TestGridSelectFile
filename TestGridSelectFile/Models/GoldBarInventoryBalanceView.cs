using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class GoldBarInventoryBalanceView
{
    public Guid? StoreId { get; set; }

    public byte? GoldBarQuality { get; set; }

    public float? WeightKpy { get; set; }

    public int? Quantity { get; set; }

    public float? TotalWeightKpy { get; set; }

    public string StoreCode { get; set; } = null!;

    public string? StoreDescription { get; set; }
}
