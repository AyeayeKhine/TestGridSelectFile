using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class StockRecondition
{
    public Guid Id { get; set; }

    public long ReconditionId { get; set; }

    public string ReconditionCode { get; set; } = null!;

    public string? ReconditionDescription { get; set; }

    public DateOnly? ReconditionDate { get; set; }

    public Guid? SmithId { get; set; }

    public float? PayWeightKpy { get; set; }

    public DateOnly? PayDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public bool IsReturn { get; set; }

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

    public virtual SmithSmith? Smith { get; set; }
}
