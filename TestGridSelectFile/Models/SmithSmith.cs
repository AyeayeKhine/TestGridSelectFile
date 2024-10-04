using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SmithSmith
{
    public Guid Id { get; set; }

    public long SmithId { get; set; }

    public string SmithCode { get; set; } = null!;

    public string? SmithDescription { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public double? Balance { get; set; }

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

    public virtual ICollection<JewelJewelInventoryIssue> JewelJewelInventoryIssues { get; set; } = new List<JewelJewelInventoryIssue>();

    public virtual ICollection<OrderOrderItem> OrderOrderItems { get; set; } = new List<OrderOrderItem>();

    public virtual ICollection<SmithSmithTransaction> SmithSmithTransactions { get; set; } = new List<SmithSmithTransaction>();

    public virtual ICollection<StockItem> StockItems { get; set; } = new List<StockItem>();

    public virtual ICollection<StockRecondition> StockReconditions { get; set; } = new List<StockRecondition>();
}
