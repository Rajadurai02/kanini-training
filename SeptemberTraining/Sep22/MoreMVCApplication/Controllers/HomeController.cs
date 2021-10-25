using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoreMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoreMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (TempData["username"] != null)
            {
                string[] images = { "/images/1.PNG", "/images/2.PNG" };
                ViewBag.Images = images;
                ViewBag.Username = TempData.Peek("username");
                ViewBag.Role = TempData.Peek("role");
                ViewBag.Gender = TempData.Peek("gender");
                return View();
            }
            else
            {
                return RedirectToAction("UserLogin", "User");
            }
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
