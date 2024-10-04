using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceCategory
{
    public Guid Id { get; set; }

    public long CategoryId { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string? CategoryDescription { get; set; }

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

    public virtual ICollection<OrderOrderItem> OrderOrderItems { get; set; } = new List<OrderOrderItem>();

    public virtual ICollection<ReferenceItemCategory> ReferenceItemCategories { get; set; } = new List<ReferenceItemCategory>();

    public virtual ICollection<ReferenceSubCategory> ReferenceSubCategories { get; set; } = new List<ReferenceSubCategory>();

    public virtual ICollection<StockItem> StockItems { get; set; } = new List<StockItem>();

    public virtual ICollection<StockPlatinum> StockPlatinums { get; set; } = new List<StockPlatinum>();
}
