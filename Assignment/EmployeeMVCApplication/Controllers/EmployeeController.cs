using EmployeeMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>();
        public IActionResult Index()
        {
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("Index");
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            Employee emp = null;
            if (employees.Count > 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].Id == employee.Id)
                    {
                        emp = employees[i];
                        break;
                    }
                }
            }
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            return RedirectToAction("Index");
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
