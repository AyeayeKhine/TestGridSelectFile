using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class UserTable
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? UserType { get; set; }
}
