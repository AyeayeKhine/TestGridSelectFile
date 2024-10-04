using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class CashCashInward
{
    public Guid Id { get; set; }

    public long CashInwardId { get; set; }

    public string CashInwardCode { get; set; } = null!;

    public string? CashInwardDescription { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? Amount { get; set; }

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
}
