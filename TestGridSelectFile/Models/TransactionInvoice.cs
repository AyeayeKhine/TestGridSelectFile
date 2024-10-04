using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class TransactionInvoice
{
    public Guid Id { get; set; }

    public long InvoiceId { get; set; }

    public string InvoiceCode { get; set; } = null!;

    public string? InvoiceDescription { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public Guid? CustomerId { get; set; }

    public string? NormalCustomer { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public Guid? SalesPersonId { get; set; }

    public long? SalesTotal { get; set; }

    public long? PlatinumTotal { get; set; }

    public int? Tax { get; set; }

    public long? PurchaseTotal { get; set; }

    public long? Discount { get; set; }

    public long? GrandTotal { get; set; }

    public byte? InvoiceOption { get; set; }

    public long? Payment { get; set; }

    public long? CreditPayment { get; set; }

    public long? Balance { get; set; }

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

    public string? CustomerCode { get; set; }

    public string? CustomerDescription { get; set; }

    public string? SalesPersonCode { get; set; }

    public string? SalesPersonDescription { get; set; }

    public virtual CustomerCustomer? Customer { get; set; }

    public virtual ReferenceSalesPerson? SalesPerson { get; set; }

    public virtual ICollection<TransactionItemSale> TransactionItemSales { get; set; } = new List<TransactionItemSale>();

    public virtual ICollection<TransactionItemSalesCredit> TransactionItemSalesCredits { get; set; } = new List<TransactionItemSalesCredit>();

    public virtual ICollection<TransactionPlatinumSale> TransactionPlatinumSales { get; set; } = new List<TransactionPlatinumSale>();

    public virtual ICollection<TransactionPurchase> TransactionPurchases { get; set; } = new List<TransactionPurchase>();
}
