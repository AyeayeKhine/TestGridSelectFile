using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class SystemApplicationMenu
{
    public Guid Id { get; set; }

    public long ApplicationMenuId { get; set; }

    public string ApplicationMenuCode { get; set; } = null!;

    public string ApplicationMenuDescription { get; set; } = null!;

    public string Route { get; set; } = null!;

    public string Module { get; set; } = null!;

    public int MenuOrder { get; set; }

    public int SubMenuOrder { get; set; }

    public bool RequiresAuthenication { get; set; }

    public byte RecordAccessLevel { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
