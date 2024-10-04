using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class OrderOrderOverDueListView
{
    public long OrderId { get; set; }

    public string OrderCode { get; set; } = null!;

    public string? OrderDescription { get; set; }

    public byte? ItemOrderStatus { get; set; }

    public Guid? CustomerId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerDescription { get; set; }

    public string? NormalCustomer { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? RemindDate { get; set; }

    public long? Total { get; set; }

    public long? Discount { get; set; }

    public long? GrandTotal { get; set; }

    public long? Deposit { get; set; }

    public DateOnly? TakenDate { get; set; }

    public long? Payment { get; set; }

    public long? CreditPayment { get; set; }

    public long? Balance { get; set; }

    public DateOnly? RejectDate { get; set; }

    public string? Remark { get; set; }

    public long OrderItemId { get; set; }

    public string OrderItemCode { get; set; } = null!;

    public string? OrderItemDescription { get; set; }

    public string? ItemName { get; set; }

    public Guid? SmithId { get; set; }

    public string? SmithCode { get; set; }

    public string? SmithDescription { get; set; }

    public Guid? CategoryId { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryDescription { get; set; }

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

    public int? ItemTotal { get; set; }

    public bool? OrderCompleted { get; set; }
}
