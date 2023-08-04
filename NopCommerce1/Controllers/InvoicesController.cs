using Microsoft.AspNetCore.Mvc;
using NopCommerce1.Models;

namespace NopCommerce1.Controllers
{
	public class InvoicesController : Controller
	{
		NopCommerce1Context _nopCommerce1Context;
		public InvoicesController(NopCommerce1Context nopCommerce1Context)
		{
			_nopCommerce1Context = nopCommerce1Context;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Invoices()
		{
			var result = _nopCommerce1Context.InvoicesSells.ToList();
			return View(result);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SaveCreate(InvoicesSell model)
		{
			_nopCommerce1Context.InvoicesSells.Add(model);
			_nopCommerce1Context.SaveChanges();
			return RedirectToAction("Invoices");
		}

	}
}
