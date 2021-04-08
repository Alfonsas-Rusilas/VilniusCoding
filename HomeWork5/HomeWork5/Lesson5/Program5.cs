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
            //Exercise1();
            Exercise2();
        }

        static void Exercise2()
        {
            Console.Write("Įveskite svorį kg: ");
            int svoris_kg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite ūgį metrais: ");
            double ugis_metrais = Convert.ToDouble(Console.ReadLine());

            double kunoMasesIndex = KMI(svoris_kg, ugis_metrais);
            string strKMI = KMItoString(kunoMasesIndex);
            Console.Write(strKMI);
        }

        static string KMItoString(double kmi)
        {
            string rezult = "";

            switch (kmi)
            {
                case double dd when dd < 15:
                    rezult = "badaujantis žmogus";
                    break;
                case double dd when dd < 18.5 && dd > 15:
                    rezult = "badaujantis žmogus";
                    break;
                case double dd when dd > 18.5 && dd < 25:
                    rezult = "normalaus svorio žmogus";
                    break;
                case double dd when dd < 30 && dd > 25:
                    rezult = "turintis višsvorio žmogus";
                    break;
                case double dd when dd < 40 && dd > 30:
                    rezult = "nutukęs žmogus";
                    break;
                case double dd when dd > 40:
                    rezult = "ligotai nutukęs žmogus";
                    break;
                default:
                    rezult = "ateivis";
                    break;
            }
            return rezult;
        }

        static double KMI(int kg, double metrai)
        {
            return kg / (metrai * metrai);
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
            Console.WriteLine($"Dalmuo: {sk1 / sk2}");
        }

        static void Sandauga(int sk1 = 2, int sk2 = 3)
        {
            Console.WriteLine($"Sandauga: {sk1 * sk2}");
        }

        static void Skirtumas(int sk1 = 2, int sk2 = 3)
        {
            Console.WriteLine($"Skirtumas: {sk1 - sk2}");
        }

        static void Suma(int sk1 = 5, int sk2 = 10)
        {
            Console.WriteLine($"Suma: {sk1 + sk2}");
        }
    }
}
