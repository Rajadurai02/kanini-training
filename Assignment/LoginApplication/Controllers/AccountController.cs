using LoginApplication.Models;
using LoginApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepo<Account> _repo;
        public AccountController(IRepo<Account> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Account account)
        {
            Account acc = _repo.Get(account.UserName);
            if (acc.Password == account.Password)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return RedirectToAction("Failed");
            }
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Failed()
        {
            return View();
        }
    }
}
