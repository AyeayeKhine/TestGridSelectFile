using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class MeltingMeltingView
{
    public int Id { get; set; }

    public byte? Quality { get; set; }

    public float? MeltWeightKpy { get; set; }

    public float? RenewWeightKpy { get; set; }

    public float? OtherWeightKpy { get; set; }
}
