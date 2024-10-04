using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemProfileItem
{
    public Guid Id { get; set; }

    public long ProfileItemId { get; set; }

    public string ProfileItemCode { get; set; } = null!;

    public string? ProfileItemDescription { get; set; }

    public byte ProfileGroup { get; set; }

    public byte ProfileModule { get; set; }

    public string? ProfileCategory { get; set; }

    public int? ProfileCategorySequence { get; set; }

    public int? ProfileSequence { get; set; }

    public byte ProfileDataType { get; set; }

    public string? ProfileReferenceObject { get; set; }

    public byte? ProfileType { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public byte RecordAccessLevel { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<SystemProfile> SystemProfiles { get; set; } = new List<SystemProfile>();
}
