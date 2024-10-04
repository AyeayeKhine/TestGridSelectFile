using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SmithGoldAtSmith
{
    public Guid Id { get; set; }

    public long GoldAtSmithId { get; set; }

    public string GoldAtSmithCode { get; set; } = null!;

    public string? GoldAtSmithDescription { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public byte? GoldTransactionType { get; set; }

    public byte? Quality { get; set; }

    public float? WeightKpy { get; set; }

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
}
