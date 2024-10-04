using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemReport
{
    public Guid Id { get; set; }

    public long ReportId { get; set; }

    public string? ReportCode { get; set; }

    public string? ReportDescription { get; set; }

    public string? ReportGroup { get; set; }

    public bool IsClientReport { get; set; }

    public string? ReportFileName { get; set; }

    public string? ReportLocalPath { get; set; }

    public string? ReportServerPath { get; set; }

    public string? ReportDataSourceName { get; set; }

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

    public virtual ICollection<SecurityReportPermission> SecurityReportPermissions { get; set; } = new List<SecurityReportPermission>();
}
