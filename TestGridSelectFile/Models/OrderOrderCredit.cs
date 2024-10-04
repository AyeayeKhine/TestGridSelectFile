using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class OrderOrderCredit
{
    public Guid Id { get; set; }

    public long OrderCreditId { get; set; }

    public string OrderCreditCode { get; set; } = null!;

    public string? OrderCreditDescription { get; set; }

    public Guid OrderId { get; set; }

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

    public string? OrderCode { get; set; }

    public string? OrderDescription { get; set; }

    public virtual OrderOrder Order { get; set; } = null!;
}
