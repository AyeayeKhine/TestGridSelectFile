using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceSalesPerson
{
    public Guid Id { get; set; }

    public long SalesPersonId { get; set; }

    public string SalesPersonCode { get; set; } = null!;

    public string? SalesPersonDescription { get; set; }

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

    public virtual ICollection<GoldBarGoldBarTransaction> GoldBarGoldBarTransactions { get; set; } = new List<GoldBarGoldBarTransaction>();

    public virtual ICollection<JewelJewelTransaction> JewelJewelTransactions { get; set; } = new List<JewelJewelTransaction>();

    public virtual ICollection<OrderOrder> OrderOrders { get; set; } = new List<OrderOrder>();

    public virtual ICollection<TransactionInvoice> TransactionInvoices { get; set; } = new List<TransactionInvoice>();

    public virtual ICollection<TransactionItemSale> TransactionItemSales { get; set; } = new List<TransactionItemSale>();

    public virtual ICollection<TransactionPlatinumSale> TransactionPlatinumSales { get; set; } = new List<TransactionPlatinumSale>();

    public virtual ICollection<TransactionPurchase> TransactionPurchases { get; set; } = new List<TransactionPurchase>();
}
