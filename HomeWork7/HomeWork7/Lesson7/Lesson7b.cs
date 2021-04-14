using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.Lesson7
{
    class Lesson7b
    {
        static void Main()
        {
            /////////////////////// 7b   - collections

            List<int> main_list = new List<int>() { -1, -2, -3, -4, -5 };
            List<int> sub_list = new List<int>() { 10, 20, 30, 40, 50, 60 };

            main_list.Add(9);
            main_list.Insert(0, 0);
            PrintValues(main_list);
            Console.WriteLine($"Elementų: {main_list.Count}");

            Console.WriteLine($"main_list.Contains(20) ?: : {main_list.Contains(20)}");

            Console.WriteLine($"main_list.IndexOf(4) = {main_list.IndexOf(4)}");

            Console.WriteLine($"main_list.Find(isPositive): {main_list.Find(isPositive)}");

            Console.WriteLine($"main_list.Exists(isPositive): {main_list.Exists(isPositive)}");

            Console.WriteLine($"main_list.TrueForAll(isPositive): {main_list.TrueForAll(isPositive)}");

            main_list.Remove(60);
            main_list.RemoveAt(2);
            main_list.RemoveRange(4, 2);
            PrintValues(main_list);

            main_list.Clear();

            main_list.InsertRange(0, sub_list);
            PrintValues(main_list, "InsertRange(0, sub_list): ");

            main_list.Sort();
            PrintValues(main_list, "main_list.Sort(): ");

            main_list.RemoveAll(FindEven);
            PrintValues(main_list, "main_list.RemoveAll(FindEven): ");

            //var teigiami = new Predicate<int>(isPositive);
            //var filtered = main_list.FindAll(teigiami);
            //var filtered = main_list.FindAll(isPositive);


            //PrintValues(filtered);

            //main_list.RemoveAll(FindEven);
            //PrintValues(main_list);
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
