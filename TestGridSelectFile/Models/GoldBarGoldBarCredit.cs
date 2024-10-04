using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class GoldBarGoldBarCredit
{
    public Guid Id { get; set; }

    public long GoldBarCreditId { get; set; }

    public string GoldBarCreditCode { get; set; } = null!;

    public string? GoldBarCreditDescription { get; set; }

    public Guid GoldBarTransactionId { get; set; }

    public DateOnly? PayDate { get; set; }

    public long? Payment { get; set; }

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

    public virtual GoldBarGoldBarTransaction GoldBarTransaction { get; set; } = null!;
}
