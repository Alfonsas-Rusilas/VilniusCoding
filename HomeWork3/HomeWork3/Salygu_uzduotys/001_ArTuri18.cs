using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("Turi bent 18 metų.");
            }
            else
            {
                Console.WriteLine("Neturi 18 metų.");
            }

            if (amzius % 2 == 0)
            {
                Console.WriteLine("Amžiaus skaičius lyginis");
            }
            else
            {
                Console.WriteLine("Amžiaus skaičius nelyginis.");
            }

        }
    }
}
