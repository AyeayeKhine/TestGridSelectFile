using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class JewelJewelSize
{
    public Guid Id { get; set; }

    public long JewelSizeId { get; set; }

    public string JewelSizeCode { get; set; } = null!;

    public string? JewelSizeDescription { get; set; }

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

    public virtual ICollection<JewelJewelInventory> JewelJewelInventories { get; set; } = new List<JewelJewelInventory>();

    public virtual ICollection<JewelJewelInventoryIssue> JewelJewelInventoryIssues { get; set; } = new List<JewelJewelInventoryIssue>();

    public virtual ICollection<JewelJewelInventoryReceive> JewelJewelInventoryReceives { get; set; } = new List<JewelJewelInventoryReceive>();

    public virtual ICollection<JewelJewelTransactionDetail> JewelJewelTransactionDetails { get; set; } = new List<JewelJewelTransactionDetail>();
}
