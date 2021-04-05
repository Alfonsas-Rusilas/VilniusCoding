using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Git_uzduotys
{
    class _008_funkcijos_ir_metodai
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pirmą skaičių: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Didžiausias skaičius yra {Max(sk1,sk2,sk3)}");
            Console.WriteLine($"Ar pirmas skaičius papuola į intervalą: {InRange(sk1, sk2, sk3)}");
            Console.WriteLine($"Ar pirmas skaičius pirminis: {InPrimal(sk1)}");
        }

        static int Max(int ska1, int ska2, int ska3)
        {
            int didziausias = (ska1 > ska2 && ska1 > ska3) ? ska1 : (ska2 > ska3) ? ska2 : ska3;
            return didziausias;
        }

        static bool InRange(int value, int range1, int range2)
        {
            if (value > range1 && value < range2) return true; else return false; 
        }

        static bool InPrimal(int p)
        {
            bool rezultatas = false;
            var pirminiai = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
            for (int i=0; i<pirminiai.Count; i++)
            {
                if (p == pirminiai[i]) rezultatas = true;
            }
            return rezultatas;
        }
    }
}
