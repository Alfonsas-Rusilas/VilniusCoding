using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.Factory
{
    class Car
    {
        // access specifier: kas gali matyti/manipuliuoti elementais. 
        //      Public: pasiekiamas iš išorės;
        //      Private: tik klasės viduje (nenurodžius pagal nutylėjimą)

        public string Model;
        public int Year;
        private bool IsInsured;

        public Car(string model = "Audi", int year = 2021)
        {
            Model = model;
            Year = year;
        }

        private void IgnitePetrol()
        {
            Console.WriteLine("IgnitePetrol: working");
        }

    }
}
