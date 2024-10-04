using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemProfile
{
    public Guid Id { get; set; }

    public long ProfileId { get; set; }

    public Guid? ProfileItemId { get; set; }

    public Guid? RecordId { get; set; }

    public string? DataValue { get; set; }

    public string? DataValueCode { get; set; }

    public string? DataValueDescription { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public byte RecordAccessLevel { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? ProfileItemCode { get; set; }

    public string? ProfileItemDescription { get; set; }

    public virtual SystemProfileItem? ProfileItem { get; set; }
}
