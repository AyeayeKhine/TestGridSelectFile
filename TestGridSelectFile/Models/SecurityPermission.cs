using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SecurityPermission
{
    public Guid Id { get; set; }

    public long PermissionId { get; set; }

    public string PermissionCode { get; set; } = null!;

    public string PermissionDescription { get; set; } = null!;

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

    public virtual ICollection<SecurityGroupPermission> SecurityGroupPermissions { get; set; } = new List<SecurityGroupPermission>();
}
