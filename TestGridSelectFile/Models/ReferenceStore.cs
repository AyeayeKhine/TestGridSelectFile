using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class ReferenceStore
{
    public Guid Id { get; set; }

    public long StoreId { get; set; }

    public string StoreCode { get; set; } = null!;

    public string? StoreDescription { get; set; }

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

    public virtual ICollection<GoldBarGoldBarInventory> GoldBarGoldBarInventories { get; set; } = new List<GoldBarGoldBarInventory>();

    public virtual ICollection<GoldBarGoldBarInventoryTransfer> GoldBarGoldBarInventoryTransferFromStores { get; set; } = new List<GoldBarGoldBarInventoryTransfer>();

    public virtual ICollection<GoldBarGoldBarInventoryTransfer> GoldBarGoldBarInventoryTransferToStores { get; set; } = new List<GoldBarGoldBarInventoryTransfer>();

    public virtual ICollection<GoldBarGoldBarTransactionDetail> GoldBarGoldBarTransactionDetails { get; set; } = new List<GoldBarGoldBarTransactionDetail>();

    public virtual ICollection<GoldBarInventoryIssue> GoldBarInventoryIssues { get; set; } = new List<GoldBarInventoryIssue>();

    public virtual ICollection<GoldBarInventoryReceive> GoldBarInventoryReceives { get; set; } = new List<GoldBarInventoryReceive>();

    public virtual ICollection<StockItem> StockItems { get; set; } = new List<StockItem>();
}
