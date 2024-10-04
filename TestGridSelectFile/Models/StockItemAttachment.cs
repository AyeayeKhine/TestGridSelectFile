using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class StockItemAttachment
{
    public Guid Id { get; set; }

    public long ItemAttachmentId { get; set; }

    public string ItemAttachmentCode { get; set; } = null!;

    public string? ItemAttachmentDescription { get; set; }

    public string? Photo { get; set; }

    public Guid ItemId { get; set; }

    public bool IsCover { get; set; }

    public string? Remark { get; set; }

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

    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public virtual StockItem Item { get; set; } = null!;
}
