using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC.Controllers
{
    public class DebugController : Controller
    {
        // default is [HTTPGet], todėl net nerašomas.
        // Internetinis puslapis naudoja tik GET ir POST
        public string Test()
        {
            //return View();
            Debug.WriteLine("debug langui žinutė");
            return "Labas pasauli!";
        }

        public IActionResult TestSome()
        {
            return View();
        }


        // ActionName - pakeičia Action pavadinimą
        [ActionName("ParamTest")]
        public string GetParameter(int id = 123456789)
        {
            return "I got id: " + id;
        }

    }
}
