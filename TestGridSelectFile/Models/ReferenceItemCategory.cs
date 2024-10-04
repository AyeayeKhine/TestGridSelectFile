using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceItemCategory
{
    public Guid Id { get; set; }

    public long ItemCategoryId { get; set; }

    public string ItemCategoryCode { get; set; } = null!;

    public string? ItemCategoryDescription { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? SubCategoryId { get; set; }

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

    public string? SubCategoryCode { get; set; }

    public string? SubCategoryDescription { get; set; }

    public virtual ReferenceCategory? Category { get; set; }

    public virtual ICollection<StockItem> StockItems { get; set; } = new List<StockItem>();

    public virtual ReferenceSubCategory? SubCategory { get; set; }
}
