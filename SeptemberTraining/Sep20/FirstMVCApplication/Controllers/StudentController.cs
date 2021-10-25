using FirstMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();
        public IActionResult Index()
        {
            //ViewBag.Name = "Raja";// new one dynamic type no casting required
            //ViewData["username"] = "userRaja";
            //int[] score = { 100, 98, 92, 80, 85 };
            //ViewBag.Scores = score;
            //ViewData["Scores"] = score;
            //Student student = new Student();
            //student.Id = 101;
            //student.Name = "Rajadurai";
            //student.Age = 21;
            //ViewBag.Student = student;
            return View(students);
        }
        [HttpGet]//that is default no need to mention it
        public IActionResult Create()
        {
            return View();
        }
        //must be mentioned after the presssed create button where it go
        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }
    }
}
