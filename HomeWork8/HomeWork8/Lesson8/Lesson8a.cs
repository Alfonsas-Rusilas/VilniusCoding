using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Lesson8a
    {
        static void Main()
        {
            //Console.WriteLine("Hello World!");
            // Klasė - tai aprašas (kokie duomenys, ir kaip būsimas objektas veiks).
            // 


            ////////// Lesson 8.a


            List<string> words = new List<string>() { "vienas", "du", "trys" };
            words.Add("testas"); words.Insert(2, "kart du");

            words.Remove("vienas"); 
            words.RemoveAt(2); 
            words.Clear(); 
            words.Count(); 
            words.Contains("vienas"); 
            words.IndexOf("vienas");

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
