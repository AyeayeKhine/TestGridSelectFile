using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemMonitor
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;

    public Guid? RecordId { get; set; }

    public string? ParentDocument { get; set; }

    public Guid? UserId { get; set; }

    public int? SystemStatus { get; set; }

    public DateTime? TimeStamp { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }

    public string? Custom4 { get; set; }

    public string? Custom5 { get; set; }

    public short RecordAccessLevel { get; set; }

    public string? UserCode { get; set; }

    public string? UserDescription { get; set; }

    public virtual SecurityUser? User { get; set; }
}
