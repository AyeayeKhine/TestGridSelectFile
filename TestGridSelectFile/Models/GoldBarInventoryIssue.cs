using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class GoldBarInventoryIssue
{
    public Guid Id { get; set; }

    public long InventoryIssueId { get; set; }

    public string InventoryIssueCode { get; set; } = null!;

    public string? InventoryIssueDescription { get; set; }

    public DateOnly? IssueDate { get; set; }

    public Guid? StoreId { get; set; }

    public byte? IssueType { get; set; }

    public byte? GoldBarQuality { get; set; }

    public float? WeightKpy { get; set; }

    public int? Quantity { get; set; }

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

    public string? StoreCode { get; set; }

    public string? StoreDescription { get; set; }

    public virtual ICollection<GoldBarGoldBarInventory> GoldBarGoldBarInventories { get; set; } = new List<GoldBarGoldBarInventory>();

    public virtual ReferenceStore? Store { get; set; }
}
