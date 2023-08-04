using Microsoft.AspNetCore.Mvc;
using HelloWorldApp.Models;

namespace HelloWorldApp.Controllers;
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();  
    }
    public ActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public ViewResult Employees() 
    {
        return View(); 
    }
    [HttpPost]
    public ViewResult Employees(Employee employee) 
    {
        if (ModelState.IsValid)
        {
            Repository.AddEmployee(employee);
            return View("ConfirmPage", employee);
        }
        else
            return View();
    }
    public ViewResult AllEmployees()
    {
        return View(Repository.GetEmployees().Where(emp=>emp.isActive == true));
    }

}
