using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemIntervalSetting
{
    public Guid Id { get; set; }

    public long IntervalSettingId { get; set; }

    public string IntervalSettingCode { get; set; } = null!;

    public string IntervalSettingDescription { get; set; } = null!;

    public byte IntervalType { get; set; }

    public byte CurrentFrom { get; set; }

    public int Interval { get; set; }

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
