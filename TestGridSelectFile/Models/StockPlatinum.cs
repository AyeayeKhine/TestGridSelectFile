using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class StockPlatinum
{
    public Guid Id { get; set; }

    public long PlatinumId { get; set; }

    public string PlatinumCode { get; set; } = null!;

    public string? PlatinumDescription { get; set; }

    public Guid? CategoryId { get; set; }

    public DateOnly? RegDate { get; set; }

    public float? Weight { get; set; }

    public int? ItemPrice { get; set; }

    public int? Total { get; set; }

    public string? ItemSummary { get; set; }

    public byte? ItemStatus { get; set; }

    /// <summary>
    /// Update Date when item was sold or melt
    /// </summary>
    public DateOnly? TransactionDate { get; set; }

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

    public string? CategoryCode { get; set; }

    public string? CategoryDescription { get; set; }

    public virtual ReferenceCategory? Category { get; set; }

    public virtual ICollection<TransactionPlatinumSale> TransactionPlatinumSales { get; set; } = new List<TransactionPlatinumSale>();
}
