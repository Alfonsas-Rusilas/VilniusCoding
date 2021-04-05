using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Salygu_uzduotys
{
    class _004_switch_tikrinimai
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pirmą skaičių: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            switch (sk1)
            {
                case 1:
                    Console.WriteLine($"Trijų skaičių suma: {sk1 + sk2 + sk3}");
                    break;
                case 2:
                    Console.WriteLine($"Skaičių skirtumas: {sk1 - sk3}");
                    break;
                case 3:
                    Console.WriteLine($"Skaičių sandauga: {sk2 * sk3}");
                    break;
                default:
                    break;
            }
        }
    }
}
