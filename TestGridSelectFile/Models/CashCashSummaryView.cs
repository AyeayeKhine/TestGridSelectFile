using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class CashCashSummaryView
{
    public int Id { get; set; }

    public DateTime? SaleDate { get; set; }

    public decimal? Amount { get; set; }

    public string? Description { get; set; }
}
