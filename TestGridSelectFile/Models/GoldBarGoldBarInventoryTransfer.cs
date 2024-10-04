using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class GoldBarGoldBarInventoryTransfer
{
    public Guid Id { get; set; }

    public long GoldBarInventoryTransferId { get; set; }

    public string GoldBarInventoryTransferCode { get; set; } = null!;

    public string? GoldBarInventoryTransferDescription { get; set; }

    public DateOnly? TransferDate { get; set; }

    public Guid? FromStoreId { get; set; }

    public Guid? ToStoreId { get; set; }

    public byte? GoldBarQuality { get; set; }

    public float? WeightKpy { get; set; }

    public int? Quantity { get; set; }

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

    public string? FromStoreCode { get; set; }

    public string? FromStoreDescription { get; set; }

    public string? ToStoreCode { get; set; }

    public string? ToStoreDescription { get; set; }

    public virtual ReferenceStore? FromStore { get; set; }

    public virtual ICollection<GoldBarGoldBarInventory> GoldBarGoldBarInventories { get; set; } = new List<GoldBarGoldBarInventory>();

    public virtual ReferenceStore? ToStore { get; set; }
}
