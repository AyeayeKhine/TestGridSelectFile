using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemOption
{
    public Guid Id { get; set; }

    public string OptionCode { get; set; } = null!;

    public string OptionDescription { get; set; } = null!;

    public string OptionGroup { get; set; } = null!;

    public string OptionModule { get; set; } = null!;

    public int OptionModuleSequence { get; set; }

    public int OptionGroupSequence { get; set; }

    public int OptionSequence { get; set; }

    public string? OptionCategory { get; set; }

    public string OptionDataType { get; set; } = null!;

    public string? OptionReferenceObject { get; set; }

    public string? OptionValue { get; set; }

    public string? OptionValueCode { get; set; }

    public string? OptionValueDescription { get; set; }

    public byte OptionType { get; set; }

    public Guid UserId { get; set; }

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

    public virtual SecurityUser User { get; set; } = null!;
}
