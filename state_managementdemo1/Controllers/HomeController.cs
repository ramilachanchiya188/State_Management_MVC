using Microsoft.AspNetCore.Mvc;
using state_managementdemo1.Models;
using System.Diagnostics;

namespace state_managementdemo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor contx;
        public HomeController(IHttpContextAccessor contx)
        {
            this.contx = contx;
        }
        public IActionResult Index()
        {
            contx.HttpContext.Session.SetInt32("RollNo", 45);
            contx.HttpContext.Session.SetString("Username", "Ramila");
            return View();
        }

       
        public IActionResult StateDemo()
        {
            ViewData["test"] = "RkUniversity";
            ViewBag.city = "Rajkot";
            TempData["state"] = "Gujarat";
            //return View();
            return RedirectToAction("Privacy");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
