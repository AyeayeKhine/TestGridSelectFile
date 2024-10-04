using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class StockItemDetail
{
    public Guid Id { get; set; }

    public long ItemDetailId { get; set; }

    public string ItemDetailCode { get; set; } = null!;

    public string? ItemDetailDescription { get; set; }

    public Guid ItemId { get; set; }

    public Guid? JewelTypeId { get; set; }

    public float? PackSize { get; set; }

    public float? Quantity { get; set; }

    public bool IsSingleJewel { get; set; }

    public float? JewelYatiPyi { get; set; }

    public float? Kpy { get; set; }

    public int? LatestPrice { get; set; }

    public int? JewelCost { get; set; }

    public DateOnly? LastUpdatedDate { get; set; }

    public int? InitialPrice { get; set; }

    public int? PurchaseJewelPrice { get; set; }

    public string? Dimension { get; set; }

    public string? Shape { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public short RecordAccessLevel { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }

    public string? Custom4 { get; set; }

    public string? Custom5 { get; set; }

    public string? JewelTypeCode { get; set; }

    public string? JewelTypeDescription { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public virtual StockItem Item { get; set; } = null!;

    public virtual ReferenceJewelType? JewelType { get; set; }
}
