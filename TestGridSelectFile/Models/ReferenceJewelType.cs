using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceJewelType
{
    public Guid Id { get; set; }

    public long JewelTypeId { get; set; }

    public string JewelTypeCode { get; set; } = null!;

    public string? JewelTypeDescription { get; set; }

    public decimal? YatiPrice { get; set; }

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

    public virtual ICollection<JewelJewel> JewelJewels { get; set; } = new List<JewelJewel>();

    public virtual ICollection<OrderOrderItemDetail> OrderOrderItemDetails { get; set; } = new List<OrderOrderItemDetail>();

    public virtual ICollection<StockItemDetail> StockItemDetails { get; set; } = new List<StockItemDetail>();

    public virtual ICollection<TransactionItemSalesDetail> TransactionItemSalesDetails { get; set; } = new List<TransactionItemSalesDetail>();

    public virtual ICollection<TransactionPurchaseDetail> TransactionPurchaseDetails { get; set; } = new List<TransactionPurchaseDetail>();
}
