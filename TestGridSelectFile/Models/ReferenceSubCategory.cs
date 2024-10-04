using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceSubCategory
{
    public Guid Id { get; set; }

    public long SubCategoryId { get; set; }

    public string SubCategoryCode { get; set; } = null!;

    public string? SubCategoryDescription { get; set; }

    public Guid? CategoryId { get; set; }

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

    public string? CategoryCode { get; set; }

    public string? CategoryDescription { get; set; }

    public virtual ReferenceCategory? Category { get; set; }

    public virtual ICollection<ReferenceItemCategory> ReferenceItemCategories { get; set; } = new List<ReferenceItemCategory>();

    public virtual ICollection<StockItem> StockItems { get; set; } = new List<StockItem>();
}
