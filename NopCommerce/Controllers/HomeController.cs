using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NopCommerce.Models;

namespace NopCommerce.Controllers
{
    public class HomeController : Controller
    {
        NopCommerceContext _nopCommerceContext;
        public HomeController(NopCommerceContext nopCommerceContext)
        {
            _nopCommerceContext = nopCommerceContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Invoices()
        {
            var result=_nopCommerceContext.InvoiceSells.ToList();
            return View(result);
        }
    }
}