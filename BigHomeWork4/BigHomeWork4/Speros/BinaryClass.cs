using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Speros
{

    public delegate void binary();

    class Program2
    {
        static void Main(string[] args)
        {
            binary BinarySystem;
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                BinarySystem = DisplayOne;
            }
            else if (number == 0)
            {
                BinarySystem = DisplayZero;
            }
            else
            {
                BinarySystem = DisplayException;
            }

            BinarySystem();

            Console.ReadKey();
        }


        static void DisplayOne()
        {
            Console.WriteLine("Binary one");
        }

        static void DisplayZero()
        {
            Console.WriteLine("Binary zero");
        }

        static void DisplayException()
        {
            Console.WriteLine("This number doesn't exist in the binary system!");
        }
    }
}
