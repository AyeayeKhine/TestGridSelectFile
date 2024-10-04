using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class JewelJewelInventoryIssue
{
    public Guid Id { get; set; }

    public long JewelInventoryIssueId { get; set; }

    public string JewelInventoryIssueCode { get; set; } = null!;

    public string? JewelInventoryIssueDescription { get; set; }

    public DateOnly? IssueDate { get; set; }

    public byte? IssueType { get; set; }

    public Guid? JewelId { get; set; }

    public Guid? JewelSizeId { get; set; }

    public int? Quantity { get; set; }

    public float? Carat { get; set; }

    public Guid? SmithId { get; set; }

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

    public string? JewelSizeCode { get; set; }

    public string? JewelSizeDescription { get; set; }

    public string? JewelCode { get; set; }

    public string? JewelDescription { get; set; }

    public string? SmithCode { get; set; }

    public string? SmithDescription { get; set; }

    public virtual JewelJewel? Jewel { get; set; }

    public virtual ICollection<JewelJewelInventory> JewelJewelInventories { get; set; } = new List<JewelJewelInventory>();

    public virtual JewelJewelSize? JewelSize { get; set; }

    public virtual SmithSmith? Smith { get; set; }
}
