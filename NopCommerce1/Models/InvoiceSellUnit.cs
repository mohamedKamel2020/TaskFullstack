using System;
using System.Collections.Generic;

namespace NopCommerce1.Models;

public partial class InvoiceSellUnit
{
    public decimal BuildingNo { get; set; }

    public long InvoiceNo { get; set; }

    public int OrderNo { get; set; }

    public decimal ItemNo { get; set; }

    public short? UnitNo { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalPlusTax { get; set; }
}
