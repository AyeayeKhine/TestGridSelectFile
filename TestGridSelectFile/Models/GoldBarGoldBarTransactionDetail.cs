using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class GoldBarGoldBarTransactionDetail
{
    public Guid Id { get; set; }

    public long GoldBarTransactionDetailId { get; set; }

    public string GoldBarTransactionDetailCode { get; set; } = null!;

    public string? GoldBarTransactionDetailDescription { get; set; }

    public Guid GoldBarTransactionId { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public bool BuyOrSell { get; set; }

    public byte? GoldBarQuality { get; set; }

    public Guid? StoreId { get; set; }

    public float? WeightKpy { get; set; }

    public int? Price { get; set; }

    public int? Quantity { get; set; }

    /// <summary>
    /// None,Add,Substract
    /// </summary>
    public byte JointOption { get; set; }

    public float? ChangedWeightKpy { get; set; }

    public long? Total { get; set; }

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

    public string? GoldBarTransactionCode { get; set; }

    public string? GoldBarTransactionDescription { get; set; }

    public string? StoreCode { get; set; }

    public string? StoreDescription { get; set; }

    public virtual ICollection<GoldBarGoldBarInventory> GoldBarGoldBarInventories { get; set; } = new List<GoldBarGoldBarInventory>();

    public virtual GoldBarGoldBarTransaction GoldBarTransaction { get; set; } = null!;

    public virtual ReferenceStore? Store { get; set; }
}
