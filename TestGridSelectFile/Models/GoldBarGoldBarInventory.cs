using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class GoldBarGoldBarInventory
{
    public Guid Id { get; set; }

    public long GoldBarInventoryId { get; set; }

    public string GoldBarInventoryCode { get; set; } = null!;

    public string? GoldBarInventoryDescription { get; set; }

    public DateTime? TransactionDate { get; set; }

    public Guid? StoreId { get; set; }

    public byte? TransactionType { get; set; }

    public byte? GoldBarQuality { get; set; }

    public float? WeightKpy { get; set; }

    public int? Quantity { get; set; }

    public Guid? GoldBarTransactionDetailId { get; set; }

    public Guid? GoldBarInventoryTransferId { get; set; }

    public Guid? InventoryReceiveId { get; set; }

    public Guid? InventoryIssueId { get; set; }

    public string? Remark { get; set; }

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

    public string? StoreCode { get; set; }

    public string? StoreDescription { get; set; }

    public string? GoldBarInventoryTransferCode { get; set; }

    public string? GoldBarInventoryTransferDescription { get; set; }

    public string? GoldBarTransactionDetailCode { get; set; }

    public string? GoldBarTransactionDetailDescription { get; set; }

    public string? InventoryReceiveCode { get; set; }

    public string? InventoryReceiveDescription { get; set; }

    public string? InventoryIssueCode { get; set; }

    public string? InventoryIssueDescription { get; set; }

    public virtual GoldBarGoldBarInventoryTransfer? GoldBarInventoryTransfer { get; set; }

    public virtual GoldBarGoldBarTransactionDetail? GoldBarTransactionDetail { get; set; }

    public virtual GoldBarInventoryIssue? InventoryIssue { get; set; }

    public virtual GoldBarInventoryReceive? InventoryReceive { get; set; }

    public virtual ReferenceStore? Store { get; set; }
}
