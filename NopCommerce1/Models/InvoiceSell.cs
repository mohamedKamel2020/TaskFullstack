using System;
using System.Collections.Generic;

namespace NopCommerce1.Models;

public partial class InvoiceSell
{
    public decimal BuildingNo { get; set; }

    public long InvoiceNo { get; set; }

    public string AName { get; set; } = null!;

    public string? EName { get; set; }

    public DateTime DateG { get; set; }

    public string? DateH { get; set; }

    public decimal? ClientVendorNo { get; set; }

    public string? MainContact1 { get; set; }

    public string? InvoiceVatid { get; set; }
}
