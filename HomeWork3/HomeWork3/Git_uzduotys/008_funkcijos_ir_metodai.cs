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
            Console.WriteLine($"Random skaičius iš D20: {D20()}");
            Console.WriteLine($"Random skaičius iš D10: {D10()}");
            Console.WriteLine($"Random skaičius iš D6: {D6()}");
            Funkcija_skaicius_intervale(12, 100);
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
            var pirminiai = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109 };
            for (int i=0; i<pirminiai.Count; i++)
            {
                if (p == pirminiai[i]) rezultatas = true;
            }
            return rezultatas;
        }

        static int D20()
        {
            Random _random = new Random();
            return _random.Next(1, 20);
        }

        static int D10()
        {
            Random _random = new Random();
            return _random.Next(1, 10);
        }

        static int D6()
        {
            Random _random = new Random();
            return _random.Next(1, 6);
        }

        static void Funkcija_skaicius_intervale(int nuo, int iki)
        {
            int skaicius;
            do
            {
                Console.Write($"Funkcija tikrina ar skaičius iš intervalo {nuo}..{iki}. Įveskite skaičių: ");
                skaicius = Convert.ToInt32(Console.ReadLine());
            } while (!InRange(skaicius, nuo, iki));
            Console.Write($"Puiku: {skaicius}");
        }
    }
}
