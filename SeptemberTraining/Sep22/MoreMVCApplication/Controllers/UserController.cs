using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoreMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreMVCApplication.Controllers
{
    public class UserController : Controller
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        public IActionResult UserLogin()
        {
            _logger.LogInformation("Login hit " + DateTime.Now.ToString());
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Username.Length == 3 && user.Password.Length == 4)
                {
                    TempData["username"] = user.Username;
                    TempData["gender"] = user.Gender;
                    TempData["role"] = user.Role;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    _logger.LogError("Login Failed " + DateTime.Now.ToString());
                }
            }
            return View();
        }
        
    }
}
