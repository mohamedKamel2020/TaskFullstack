using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}
		public IActionResult Privcy()
		{
			return View();
		}
		public IActionResult ContactUS() 
		{
			return View();
		}

	}
}
