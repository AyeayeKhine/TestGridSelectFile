using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class JewelJewel
{
    public Guid Id { get; set; }

    public long JewelId { get; set; }

    public string JewelCode { get; set; } = null!;

    public string? JewelDescription { get; set; }

    public Guid? JewelTypeId { get; set; }

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

    public string? JewelTypeCode { get; set; }

    public string? JewelTypeDescription { get; set; }

    public virtual ICollection<JewelJewelAttachment> JewelJewelAttachments { get; set; } = new List<JewelJewelAttachment>();

    public virtual ICollection<JewelJewelInventory> JewelJewelInventories { get; set; } = new List<JewelJewelInventory>();

    public virtual ICollection<JewelJewelInventoryIssue> JewelJewelInventoryIssues { get; set; } = new List<JewelJewelInventoryIssue>();

    public virtual ICollection<JewelJewelInventoryReceive> JewelJewelInventoryReceives { get; set; } = new List<JewelJewelInventoryReceive>();

    public virtual ICollection<JewelJewelTransactionDetail> JewelJewelTransactionDetails { get; set; } = new List<JewelJewelTransactionDetail>();

    public virtual ReferenceJewelType? JewelType { get; set; }
}
