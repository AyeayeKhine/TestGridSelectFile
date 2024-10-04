using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class CustomerCustomer
{
    public Guid Id { get; set; }

    public long CustomerId { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? CustomerDescription { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

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

    public virtual ICollection<GoldBarGoldBarTransaction> GoldBarGoldBarTransactions { get; set; } = new List<GoldBarGoldBarTransaction>();

    public virtual ICollection<JewelJewelTransaction> JewelJewelTransactions { get; set; } = new List<JewelJewelTransaction>();

    public virtual ICollection<OrderOrder> OrderOrders { get; set; } = new List<OrderOrder>();

    public virtual ICollection<TransactionInvoice> TransactionInvoices { get; set; } = new List<TransactionInvoice>();
}
