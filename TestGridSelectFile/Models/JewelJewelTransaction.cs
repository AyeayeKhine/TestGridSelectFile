using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class JewelJewelTransaction
{
    public Guid Id { get; set; }

    public long JewelTransactionId { get; set; }

    public string JewelTransactionCode { get; set; } = null!;

    public string? JewelTransactionDescription { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public Guid? CustomerId { get; set; }

    public string? NormalCustomer { get; set; }

    public long? BuyTotal { get; set; }

    public long? SellTotal { get; set; }

    public int? Tax { get; set; }

    public long? Discount { get; set; }

    public long? GrandTotal { get; set; }

    public long? Payment { get; set; }

    public long? CreditPayment { get; set; }

    public long? Balance { get; set; }

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

    public string? JewelCode { get; set; }

    public string? JewelDescription { get; set; }

    public string? SmithCode { get; set; }

    public string? SmithDescription { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerDescription { get; set; }

    public string? CounterCode { get; set; }

    public string? CounterDescription { get; set; }

    public string? SalesPersonCode { get; set; }

    public string? SalesPersonDescription { get; set; }

    public virtual ReferenceCounter? Counter { get; set; }

    public virtual CustomerCustomer? Customer { get; set; }

    public virtual ICollection<JewelJewelTransactionDetail> JewelJewelTransactionDetails { get; set; } = new List<JewelJewelTransactionDetail>();

    public virtual ReferenceSalesPerson? SalesPerson { get; set; }
}
