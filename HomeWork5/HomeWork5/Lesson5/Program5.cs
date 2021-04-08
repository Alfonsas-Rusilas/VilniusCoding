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
        // static void MyMethod(string country = "Norway") 
        // static void MyMethod(string fname, int age) 
        //
        // static void MyMethod(string child1, string child2, string child3) 
        // MyMethod(child3: "John", child1: "Liam", child2: "Liam"); 
        //
        // static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        // 
        // int MyMethod(int x)
        // float MyMethod(float x)
        // double MyMethod(double x, double y)
        //
        // DoSom(leftParam:5, rightParam:84) - nurodome parametrus pagal vardą
        //
        // Ctrl + . //// sukuria karkasą pagal pavadinimą (arba Alt + Shift + F10)

        //////////////////// Metodai ir Funkcijos ////////////////////////
        /*
        static void Main()
        {
            Console.WriteLine("==============================");
            SayHello();
            //SaySomething();
          
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
        */
        //////////////// 5.a /////////////////////////////////

        static void Main()
        {
            Console.WriteLine("======================== 5.a ===========================");
            Exercise1();
        }

        static void Exercise1()
        {
            Console.Write("Įveskite pirmą skaičių: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite antrą skaičių: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            Suma(sk1,sk2);
            Skirtumas(sk1, sk2);
            Sandauga(sk1, sk2);
            Dalmuo(sk1, sk2);
            
            Suma();
            Skirtumas();
            Sandauga();
            Dalmuo();
        }

        static void Dalmuo(int sk1 = 2, int sk2 = 3)
        {
            Console.WriteLine($"Dalmuo: {sk1} ir {sk2}");
        }

        static void Sandauga(int sk1 = 2, int sk2 = 3)
        {
            Console.WriteLine($"Sandauga: {sk1} ir {sk2}");
        }

        static void Skirtumas(int sk1 = 2, int sk2 = 3)
        {
            Console.WriteLine($"Skirtumas: {sk1} ir {sk2}");
        }

        static void Suma(int sk1 = 5, int sk2 = 10)
        {
            Console.WriteLine($"Suma: {sk1} ir {sk2}");
        }
    }
}
