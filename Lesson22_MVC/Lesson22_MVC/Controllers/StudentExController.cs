using Lesson22_MVC.Models.Universitity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC.Controllers
{
    public class StudentExController : Controller
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


        // GET: StudentExController
        public ActionResult Index()
        {
            return View(Students);
        }

        // GET: StudentExController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentExController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentExController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentExController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentExController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentExController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentExController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
