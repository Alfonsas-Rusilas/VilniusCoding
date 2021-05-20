using Lesson22_MVC.Models.Universitity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC.Controllers
{
    public class StudentController : Controller
    {

            static List<Student> Students = new List<Student>()
            {
                new Student(){Id=0, Name="Petras", City = "Vilnius", Score = 1.5, IsGettingTuition = true },
                new Student(){Id=1, Name="Mery", City = "Cicėnai", Score = 5.2, IsGettingTuition = true },
                new Student(){Id=2, Name="Puodas", City = "Vilnius", Score = 2.5, IsGettingTuition = false },
                new Student(){Id=3, Name="Tadas", City = "Narėpai", Score = 1.8, IsGettingTuition = true },
                new Student(){Id=4, Name="Gedas", City = "Vilnius", Score = 8.5, IsGettingTuition = true },
                new Student(){Id=5, Name="Rimas", City = "Šveicarija", Score = 10.0, IsGettingTuition = true },
                new Student(){Id=6, Name="Petras", City = "Vilnius", Score = 4.5, IsGettingTuition = false },
                new Student(){Id=7, Name="Rima", City = "Marijampolė", Score = 5.4, IsGettingTuition = true },
                new Student(){Id=8, Name="Alfa", City = "Kaunas", Score = 5.8, IsGettingTuition = true },
            };

        public IActionResult Index()
        {
            return View(Students);
        }

        public IActionResult Delete(int id)
        {
            return View(Students.Find(s => s.Id == id));
        }

        [HttpPost]
        public IActionResult Delete(Student student) //public IActionResult Delete([Bind(id, name)]Student student)
        {
            Students.RemoveAll(s => s.Id == student.Id);
            
            // error check
            
            return RedirectToAction(nameof(Index)); // arba "Index"
        }


        public IActionResult Create()
        {
            if (ModelState.IsValid) {
                //
            }
            return View();
        }


        [HttpPost]
        public IActionResult Create(Student student)
        {
            string score = student.Score.ToString();
            Students.Add(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            return View(Students.Find(s => s.Id == id));
        }


    }
}
