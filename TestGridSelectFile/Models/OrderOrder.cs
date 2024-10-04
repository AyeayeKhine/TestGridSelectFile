using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class OrderOrder
{
    public Guid Id { get; set; }

    public long OrderId { get; set; }

    public string OrderCode { get; set; } = null!;

    public string? OrderDescription { get; set; }

    public byte? ItemOrderStatus { get; set; }

    public Guid? CustomerId { get; set; }

    public string? NormalCustomer { get; set; }

    public string? PhoneNumber { get; set; }

    public Guid? CounterId { get; set; }

    public Guid? SalesPersonId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? RemindDate { get; set; }

    public long? Total { get; set; }

    public long? Tax { get; set; }

    public long? Discount { get; set; }

    public long? GrandTotal { get; set; }

    public long? Deposit { get; set; }

    public DateOnly? TakenDate { get; set; }

    public long? Payment { get; set; }

    public long? CreditPayment { get; set; }

    public long? Balance { get; set; }

    public DateOnly? RejectDate { get; set; }

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

    public string? CustomerCode { get; set; }

    public string? CustomerDescription { get; set; }

    public string? CounterCode { get; set; }

    public string? CounterDescription { get; set; }

    public string? SalesPersonCode { get; set; }

    public string? SalesPersonDescription { get; set; }

    public virtual ReferenceCounter? Counter { get; set; }

    public virtual CustomerCustomer? Customer { get; set; }

    public virtual ICollection<OrderOrderCredit> OrderOrderCredits { get; set; } = new List<OrderOrderCredit>();

    public virtual ICollection<OrderOrderItem> OrderOrderItems { get; set; } = new List<OrderOrderItem>();

    public virtual ReferenceSalesPerson? SalesPerson { get; set; }
}
