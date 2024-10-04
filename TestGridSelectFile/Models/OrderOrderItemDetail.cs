using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class OrderOrderItemDetail
{
    public Guid Id { get; set; }

    public long OrderItemDetailId { get; set; }

    public string OrderItemDetailCode { get; set; } = null!;

    public string? OrderItemDetailDescription { get; set; }

    public Guid OrderItemId { get; set; }

    public Guid? JewelTypeId { get; set; }

    public float? PackSize { get; set; }

    public float? Quantity { get; set; }

    public bool IsSingleJewel { get; set; }

    public float? JewelYatiPyi { get; set; }

    public float? Kpy { get; set; }

    public int? Price { get; set; }

    public int? JewelCost { get; set; }

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

    public string? OrderItemCode { get; set; }

    public string? OrderItemDescription { get; set; }

    public string? JewelTypeCode { get; set; }

    public string? JewelTypeDescription { get; set; }

    public virtual ReferenceJewelType? JewelType { get; set; }

    public virtual OrderOrderItem OrderItem { get; set; } = null!;
}
