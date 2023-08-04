using Microsoft.AspNetCore.Mvc;
using NopCommerce2.Models;

namespace NopCommerce2.Controllers
{
	public class InvoiceController : Controller
	{
		NopCommerce2Context _nopCommerce2Context;
		public InvoiceController(NopCommerce2Context nopCommerce2Context)
		{
			_nopCommerce2Context = nopCommerce2Context;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Invoice()
		{
			var result = _nopCommerce2Context.InvoiceSells.ToList();
			return View(result);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Invoices invoices)
		{
			InvoiceSell invoiceSell = new InvoiceSell();
			invoiceSell.DateH=invoices.invoiceSell.DateH;
			invoiceSell.DateG = invoices.invoiceSell.DateG;
			invoiceSell.InvoiceNo = invoices.invoiceSell.InvoiceNo;
			invoiceSell.AName = invoices.invoiceSell.AName;
			invoiceSell.EName = invoices.invoiceSell.EName;
			invoiceSell.MainContact1 = invoices.invoiceSell.MainContact1;
			invoiceSell.InvoiceVatid = invoices.invoiceSell.InvoiceVatid;
			invoiceSell.ClientVendorNo = invoices.invoiceSell.ClientVendorNo;
			invoiceSell.InvoiceSellUnits = new List<InvoiceSellUnit>();
			foreach (var item in invoices.invoiceSellUnit)
			{
				var A = new InvoiceSellUnit()
				{
					InvoiceNo = item.InvoiceNo,
                    OrderNo = item.OrderNo,
					ItemNo  = item.ItemNo,
					UnitNo  = item.UnitNo, 
                    Quantity = item.Quantity,
                    Price  = item.Price,
                    Total  = item.Total,
                    TotalPlusTax  = item.TotalPlusTax
	            };
				invoices.invoiceSellUnit.Add(A);
			}
		    _nopCommerce2Context.InvoiceSells.Add(invoiceSell);
			_nopCommerce2Context.SaveChanges();
			return RedirectToAction("Invoice");
		}
	}
}
