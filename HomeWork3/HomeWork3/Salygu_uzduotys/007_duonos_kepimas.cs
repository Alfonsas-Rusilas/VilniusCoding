using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Salygu_uzduotys
{
    class _007_duonos_kepimas
    {
        static void Main(string[] args)
        {
            int valandos = 8;
            Console.Write("Kiek iškepama duonos kepalų per valandą: ");
            int kepalai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite kiek darbuotojų dirba: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite vieno kepalo savikainą: ");
            double savikaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite vieno kepalo pardavimo kainą: ");
            double kaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Per dieną iškepama {kepalai * valandos} kepalų duonos.");
            double dienos_savikaina = kepalai * valandos * savikaina;
            double dienos_pajamos = kepalai * valandos * kaina;
            Console.WriteLine($"Iškeptos duonos savikaina: {dienos_savikaina}, pajamos {dienos_pajamos}, pelnas {dienos_pajamos-dienos_savikaina};");
        }
    }
}
