using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemProfileDataView
{
    public Guid? Id { get; set; }

    public Guid? RecordId { get; set; }

    public string? DataValue { get; set; }

    public string? DataValueCode { get; set; }

    public string? DataValueDescription { get; set; }

    public Guid ProfileItemId { get; set; }

    public string ProfileItemCode { get; set; } = null!;

    public string? ProfileItemDescription { get; set; }

    public byte ProfileGroup { get; set; }

    public byte ProfileModule { get; set; }

    public string? ProfileCategory { get; set; }

    public int? ProfileCategorySequence { get; set; }

    public int? ProfileSequence { get; set; }

    public byte ProfileDataType { get; set; }

    public string? ProfileReferenceObject { get; set; }
}
