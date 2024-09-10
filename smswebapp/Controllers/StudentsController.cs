using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using smswebapp.Models;

public class StudentsController : Controller{

    private static List<Student> students = new List<Student>{
        new Student {Id=1, Name="Dharmesh", Address="Delhi"},
        new Student {Id=2, Name="Ramesh", Address="Surat"},
        new Student {Id=3, Name="Akshit", Address="Hyd"},
        new Student {Id=4, Name="Padhu", Address="Hyd"},
        new Student {Id=4, Name="Abhi", Address="Hyd"},
        new Student {Id=4, Name="Sai", Address="Hyd"}
    };

        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id=students.Count+1;
            students.Add(student);
            return RedirectToAction("Index");
        }

}
