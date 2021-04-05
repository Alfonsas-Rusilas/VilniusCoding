using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Salygu_uzduotys
{
    class _006_papildomos_uzduotys_a
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pirmą skaičių: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite pirmą skaičių: ");
            sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sudauginus: {sk1 * sk2 * sk3}");
            Console.WriteLine($"Sudėtis: {sk1 + sk2}; atimtis: {sk1 - sk2}; daugyba: {sk1 * sk2}; dalyba: {sk1/sk2}");

            Console.Write("Įveskite pirmą skaičių: ");
            sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: ");
            sk3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite ketvirtą skaičių: ");
            int sk4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Skaičių {sk1},{sk2},{sk3},{sk4} vidurkis yra: {(sk1+sk2+sk3+sk4)/4}");

            Console.Write("Įveskite temperatūrą Farenheitais: ");
            sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Celsijais gausis: {(sk1-32)/1.8}");
        }
    }
}
