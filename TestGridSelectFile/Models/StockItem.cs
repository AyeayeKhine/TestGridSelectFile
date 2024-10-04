using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class StockItem
{
    public Guid Id { get; set; }

    public long ItemId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? SubCategoryId { get; set; }

    public Guid? ItemCategoryId { get; set; }

    public DateOnly? RegDate { get; set; }

    public string? OtherDescription { get; set; }

    public byte? Quality { get; set; }

    public float? ItemWeightKpy { get; set; }

    public float? JewelWeightKpy { get; set; }

    public float? GoldWeightKpy { get; set; }

    public float? WasteKpy { get; set; }

    public float? TotalGoldWeightKpy { get; set; }

    public int? JewelCost { get; set; }

    public Guid? SmithId { get; set; }

    public float? SmithWasteKpy { get; set; }

    /// <summary>
    /// New,Sold,Melt,SampleOut
    /// </summary>
    public short? ItemStatus { get; set; }

    /// <summary>
    /// Update Date when item was sold or melt
    /// </summary>
    public DateOnly? TransactionDate { get; set; }

    public Guid? StoreId { get; set; }

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

    public string? CategoryCode { get; set; }

    public string? CategoryDescription { get; set; }

    public string? SubCategoryCode { get; set; }

    public string? SubCategoryDescription { get; set; }

    public string? ItemCategoryCode { get; set; }

    public string? ItemCategoryDescription { get; set; }

    public string? SmithCode { get; set; }

    public string? SmithDescription { get; set; }

    public string? StoreCode { get; set; }

    public string? StoreDescription { get; set; }

    public virtual ReferenceCategory? Category { get; set; }

    public virtual ReferenceItemCategory? ItemCategory { get; set; }

    public virtual SmithSmith? Smith { get; set; }

    public virtual ICollection<StockItemAttachment> StockItemAttachments { get; set; } = new List<StockItemAttachment>();

    public virtual ICollection<StockItemDetail> StockItemDetails { get; set; } = new List<StockItemDetail>();

    public virtual ReferenceStore? Store { get; set; }

    public virtual ReferenceSubCategory? SubCategory { get; set; }

    public virtual ICollection<TransactionItemSale> TransactionItemSales { get; set; } = new List<TransactionItemSale>();
}
