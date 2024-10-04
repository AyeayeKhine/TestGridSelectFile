using System;
using System.Collections.Generic;

namespace TestGridSelectFile.Models;

public partial class CashCreditClearingBalanceView
{
    public string Description { get; set; } = null!;

    public string InvoiceCode { get; set; } = null!;

    public DateOnly? InvoiceDate { get; set; }

    public string? NormalCustomer { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public long? Grandtotal { get; set; }

    public long? Payment { get; set; }

    public long? CreditPayment { get; set; }

    public long? Balance { get; set; }
}
