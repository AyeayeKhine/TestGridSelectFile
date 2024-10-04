using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class TransactionPlatinumSale
{
    public Guid Id { get; set; }

    public long PlatinumSalesId { get; set; }

    public string PlatinumSalesCode { get; set; } = null!;

    public string? PlatinumSalesDescription { get; set; }

    public Guid InvoiceId { get; set; }

    public Guid? PlatinumId { get; set; }

    public DateOnly? SalesDate { get; set; }

    public float? Weight { get; set; }

    public int? ItemPrice { get; set; }

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

    public string? PlatinumCode { get; set; }

    public string? PlatinumDescription { get; set; }

    public string? SalesPersonCode { get; set; }

    public string? SalesPersonDescription { get; set; }

    public virtual ReferenceCounter? Counter { get; set; }

    public virtual TransactionInvoice Invoice { get; set; } = null!;

    public virtual StockPlatinum? Platinum { get; set; }

    public virtual ReferenceSalesPerson? SalesPerson { get; set; }
}
