using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork5.Lesson5
{
    class Program5
    {
        // Funkcijos - iš didžiosios (ar didžiųjų). Standartiškai aprašomai atskirai;
        // Metodai - tai konkrečios klasės metodas
        // Jei main yra static - tai funkcijos už jos taip pat "static"
        // static or public
        // 
        static void Main()
        {
            Console.WriteLine("==============================");
            SayHello();

        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
            SaySomething();
        }

        static void SaySomething()
        {
            Console.WriteLine("SaySomething!");
            SayBay();
        }

        static void SayBay()
        {
            Console.WriteLine("SayBay...");
        }
    }
}
