using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceCounter
{
    public Guid Id { get; set; }

    public long CounterId { get; set; }

    public string CounterCode { get; set; } = null!;

    public string? CounterDescription { get; set; }

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

    public virtual ICollection<TransactionItemSale> TransactionItemSales { get; set; } = new List<TransactionItemSale>();

    public virtual ICollection<TransactionPlatinumSale> TransactionPlatinumSales { get; set; } = new List<TransactionPlatinumSale>();

    public virtual ICollection<TransactionPurchase> TransactionPurchases { get; set; } = new List<TransactionPurchase>();
}
