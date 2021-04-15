using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8
{
    class Lesson8c
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static bool isPositive(int val)
        {
            return val > 0;
        }

        static bool FindEven(int val)
        {
            return val % 2 == 0;
        }

        static void PrintValues(List<int> myList, string message = "")
        {
            Console.Write(message);
            foreach (int i in myList)
                Console.Write($"  {i}");
            Console.WriteLine();
        }

        static void PrintValues(List<string> myList, string message = "")
        {
            Console.Write(message);
            foreach (string i in myList)
                Console.Write($"   {i}");
            Console.WriteLine();
        }
    }
}
