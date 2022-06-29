using System;
using Microsoft.AspNetCore.Mvc;
using Student.Models;

namespace Student.Controllers
{
    public class HomeController: Controller{

        public IActionResult Index(){
            return View();
        }

        public IActionResult AddStudent(){
            return View();
        }

        // [HttpPost]
        // public IActionResult AddStudent(StudentModel model){
        //     Console.WriteLine(model.Name);
        //     Console.WriteLine(model.Surname);
        //     return View();
        // }

        [HttpPost]
        public JsonResult AddStudent(StudentModel student){
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            return Json(student.Name);
        }
    }
}