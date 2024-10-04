using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class TransactionPurchase
{
    public Guid Id { get; set; }

    public long PurchaseId { get; set; }

    public string PurchaseCode { get; set; } = null!;

    public string? PurchaseDescription { get; set; }

    public Guid InvoiceId { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public string? Category { get; set; }

    public byte? Quality { get; set; }

    public int? GoldPrice { get; set; }

    public int? Quantity { get; set; }

    public float? ItemWeightKpy { get; set; }

    public float? JewelWeightKpy { get; set; }

    public float? GoldWeightKpy { get; set; }

    public long? JewelCost { get; set; }

    public long? GoldCost { get; set; }

    public long? OtherCost { get; set; }

    public long? Total { get; set; }

    public Guid? CounterId { get; set; }

    public Guid? SalesPersonId { get; set; }

    public byte? RecycleType { get; set; }

    public string? Remark { get; set; }

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

    public string? SalesPersonCode { get; set; }

    public string? SalesPersonDescription { get; set; }

    public virtual ReferenceCounter? Counter { get; set; }

    public virtual TransactionInvoice Invoice { get; set; } = null!;

    public virtual ReferenceSalesPerson? SalesPerson { get; set; }

    public virtual ICollection<TransactionPurchaseDetail> TransactionPurchaseDetails { get; set; } = new List<TransactionPurchaseDetail>();
}
