using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class OrderOrderItem
{
    public Guid Id { get; set; }

    public long OrderItemId { get; set; }

    public string OrderItemCode { get; set; } = null!;

    public string? OrderItemDescription { get; set; }

    public Guid OrderId { get; set; }

    public byte? ItemOrderStatus { get; set; }

    public string? ItemName { get; set; }

    public Guid? SmithId { get; set; }

    public Guid? CategoryId { get; set; }

    public short? Quantity { get; set; }

    public byte? Quality { get; set; }

    public int? GoldPrice { get; set; }

    public float? ItemWeightKpy { get; set; }

    public float? JewelWeightKpy { get; set; }

    public float? GoldWeightKpy { get; set; }

    public float? WasteKpy { get; set; }

    public float? TotalGoldWeightKpy { get; set; }

    public int? JewelCost { get; set; }

    public int? SmithCost { get; set; }

    public int? OtherCost { get; set; }

    public float? CustomerPayGoldWeightKpy { get; set; }

    public int? CustomerPayGoldPrice { get; set; }

    public int? Total { get; set; }

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

    public string? OrderCode { get; set; }

    public string? OrderDescription { get; set; }

    public string? SmithCode { get; set; }

    public string? SmithDescription { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryDescription { get; set; }

    public virtual ReferenceCategory? Category { get; set; }

    public virtual OrderOrder Order { get; set; } = null!;

    public virtual ICollection<OrderOrderItemDetail> OrderOrderItemDetails { get; set; } = new List<OrderOrderItemDetail>();

    public virtual SmithSmith? Smith { get; set; }

    public virtual ICollection<SmithSmithTransaction> SmithSmithTransactions { get; set; } = new List<SmithSmithTransaction>();
}
