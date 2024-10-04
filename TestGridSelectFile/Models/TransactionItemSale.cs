using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class TransactionItemSale
{
    public Guid Id { get; set; }

    public long ItemSalesId { get; set; }

    public string ItemSalesCode { get; set; } = null!;

    public string? ItemSalesDescription { get; set; }

    public Guid InvoiceId { get; set; }

    public DateOnly? SalesDate { get; set; }

    public Guid? ItemId { get; set; }

    public int? GoldPrice { get; set; }

    public float? ItemWeightKpy { get; set; }

    public float? JewelWeightKpy { get; set; }

    public float? GoldWeightKpy { get; set; }

    public float? WasteKpy { get; set; }

    public float? TotalGoldWeightKpy { get; set; }

    public long? JewelCost { get; set; }

    /// <summary>
    /// None,Add,Substract
    /// </summary>
    public byte JointOption { get; set; }

    public float? ChangedWeightKpy { get; set; }

    public int? SmithCost { get; set; }

    public long? Total { get; set; }

    public int? Tax { get; set; }

    public int? Discount { get; set; }

    public Guid? CounterId { get; set; }

    public Guid? SalesPersonId { get; set; }

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

    public string? InvoiceCode { get; set; }

    public string? InvoiceDescription { get; set; }

    public string? CounterCode { get; set; }

    public string? CounterDescription { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public string? SalesPersonCode { get; set; }

    public string? SalesPersonDescription { get; set; }

    public virtual ReferenceCounter? Counter { get; set; }

    public virtual TransactionInvoice Invoice { get; set; } = null!;

    public virtual StockItem? Item { get; set; }

    public virtual ReferenceSalesPerson? SalesPerson { get; set; }

    public virtual ICollection<TransactionItemSalesDetail> TransactionItemSalesDetails { get; set; } = new List<TransactionItemSalesDetail>();
}
