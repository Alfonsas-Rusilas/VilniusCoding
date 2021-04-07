using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Pamoka_3
{
    class pamoka_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių: ");
            int a = 5;

            switch (a)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Case 5 ir 6");
                    break;
                default:
                    Console.WriteLine("Case default");
                    break;
            }
        }
    }
}
