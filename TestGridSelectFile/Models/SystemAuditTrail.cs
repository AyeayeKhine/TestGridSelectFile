using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemAuditTrail
{
    public Guid Id { get; set; }

    public DateTime? RevisionStamp { get; set; }

    public Guid? EntityId { get; set; }

    public string? TableName { get; set; }

    public string? UserName { get; set; }

    public string? Actions { get; set; }

    public string? OldData { get; set; }

    public string? NewData { get; set; }

    public string? ChangedColumns { get; set; }

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
}
