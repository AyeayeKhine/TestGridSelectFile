using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SmithSmithTransaction
{
    public Guid Id { get; set; }

    public long SmithTransactionId { get; set; }

    public string SmithTransactionCode { get; set; } = null!;

    public string? SmithTransactionDescription { get; set; }

    public Guid? OrderItemId { get; set; }

    public Guid? SmithId { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public byte? Quality { get; set; }

    public float? PayWeightKpy { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public float? ReturnWeightKpy { get; set; }

    public float? BalanceWeightKpy { get; set; }

    public float? ExceedWeightKpy { get; set; }

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

    public string? SmithCode { get; set; }

    public string? SmithDescription { get; set; }

    public string? OrderItemCode { get; set; }

    public string? OrderItemDescription { get; set; }

    public virtual OrderOrderItem? OrderItem { get; set; }

    public virtual SmithSmith? Smith { get; set; }
}
