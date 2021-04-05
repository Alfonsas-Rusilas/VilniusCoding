using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Salygu_uzduotys
{
    class _005_switch_extend
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Galima rinktis iš:\n 1 - limonadas;\n 2 - arbata;\n 3 - kakava;\n 4 - kava;\n 5 - nieko.");
            Console.Write("Pasirinkite gėrimą (t.y. skaičių): ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            switch (sk1)
            {
                case 1:
                    Console.WriteLine($"Jūs pasirinkote limonadą");
                    break;
                case 2:
                    Console.WriteLine($"Jūs pasirinkote arbatą");
                    break;
                case 3:
                    Console.WriteLine($"Jūs pasirinkote kakavą");
                    break;
                case 4:
                    Console.WriteLine($"Jūs pasirinkote kavą");
                    break;
                case 5:
                    Console.WriteLine($"Jūs nieko nepasirinkote");
                    break;
                default:
                    Console.WriteLine($"blogai įvestas pasirinkimas");
                    break;
            }
        }
    }
}
