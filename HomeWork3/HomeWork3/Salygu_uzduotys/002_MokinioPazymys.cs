using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Salygu_uzduotys
{
    class _002_MokinioPazymys
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite mokinio pažymį: ");
            int paz = Convert.ToInt32(Console.ReadLine());

            if (paz < 1 || paz > 10)
            {
                Console.WriteLine("Klaida, neteisingas pažymys.");
            }
            else if (paz == 10)
            {
                Console.WriteLine("Puiku");
            }
            else if (paz == 9 || paz == 8)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (paz == 7 || paz == 6)
            {
                Console.WriteLine("Gerai");
            }
            else if (paz == 5)
            {
                Console.WriteLine("Vidutiniškai");
            }
            else if (paz == 4)
            {
                Console.WriteLine("Bent teigiamas");
            }
            else 
            {
                Console.WriteLine("Labai blogai");
            }

        }
    }
}
