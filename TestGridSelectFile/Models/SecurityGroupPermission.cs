using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SecurityGroupPermission
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }

    public Guid PermissionId { get; set; }

    public byte PermissionNumber { get; set; }

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

    public string? GroupCode { get; set; }

    public string? GroupDescription { get; set; }

    public string? PermissionCode { get; set; }

    public string? PermissionDescription { get; set; }

    public virtual SecurityGroup Group { get; set; } = null!;

    public virtual SecurityPermission Permission { get; set; } = null!;
}
