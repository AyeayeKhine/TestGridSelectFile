using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class JewelJewelTransactionDetail
{
    public Guid Id { get; set; }

    public long JewelTransactionDetailId { get; set; }

    public string JewelTransactionDetailCode { get; set; } = null!;

    public string? JewelTransactionDetailDescription { get; set; }

    public Guid JewelTransactionId { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public bool BuyOrSell { get; set; }

    public Guid? JewelId { get; set; }

    public Guid? JewelSizeId { get; set; }

    public int? Quantity { get; set; }

    public float? Carat { get; set; }

    public int? Price { get; set; }

    /// <summary>
    /// None,Add,Substract
    /// </summary>
    public byte JointOption { get; set; }

    public float? ChangedWeightKpy { get; set; }

    public long? Total { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public byte RecordAccessLevel { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }

    public string? Custom4 { get; set; }

    public string? Custom5 { get; set; }

    public string? JewelTransactionCode { get; set; }

    public string? JewelTransactionDescription { get; set; }

    public string? JewelSizeCode { get; set; }

    public string? JewelSizeDescription { get; set; }

    public string? JewelCode { get; set; }

    public string? JewelDescription { get; set; }

    public virtual JewelJewel? Jewel { get; set; }

    public virtual JewelJewelSize? JewelSize { get; set; }

    public virtual JewelJewelTransaction JewelTransaction { get; set; } = null!;
}
