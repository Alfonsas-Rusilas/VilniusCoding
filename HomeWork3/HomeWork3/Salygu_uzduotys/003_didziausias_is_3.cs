using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Salygu_uzduotys
{
    class _003_didziausias_is_3
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pirmą teigiamą skaičių: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą teigiamą skaičių: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią teigiamą skaičių: ");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine($"Didžiausias {sk1}");
            } 
            else if (sk2 > sk3)
            {
                Console.WriteLine($"Didžiausias {sk2}");
            }
            else 
            {
                Console.WriteLine($"Didžiausias {sk3}");
            }

            if (sk1 > 100 && sk1 > sk2)
            {
                Console.WriteLine("Sąlyga teisinga: sk1 > 100 && sk1 > sk2");
            }
            if (sk2 > 0 && sk2 > sk1)
            {
                Console.WriteLine("Sąlyga teisinga: sk2 > 0 && sk2 > sk1");
            }
            if ((sk1 > sk2 && sk1 > sk3) || sk1 > 0 )
            {
                Console.WriteLine("Sąlyga teisinga: (sk1 > sk2 && sk1 > sk3) || sk1 > 0");
            }
            if ((sk3 >= 5 || sk3 <= 10) || sk3 > sk1 || sk3 > sk2)
            {
                Console.WriteLine("Sąlyga teisinga: (sk3 >= 5 || sk3 <= 10) || sk3 > sk1 || sk3 > sk2");
            }
        }
    }

}
