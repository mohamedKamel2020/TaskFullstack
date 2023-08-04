using System;
using System.Collections.Generic;

namespace NopCommerce1.Models;

public partial class InvoicesSell
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

    public int OrderNo { get; set; }

    public decimal ItemNo { get; set; }

    public short? UnitNo { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalPlusTax { get; set; }
}
