using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceGoldPrice
{
    public Guid Id { get; set; }

    public long GoldPriceId { get; set; }

    public string GoldPriceCode { get; set; } = null!;

    public string? GoldPriceDescription { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? C22kprice { get; set; }

    public int? C23kprice { get; set; }

    public int? C24kprice { get; set; }

    public bool Active { get; set; }

    public bool Enabled { get; set; }

    public short RecordAccessLevel { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }

    public string? Custom4 { get; set; }

    public string? Custom5 { get; set; }
}
