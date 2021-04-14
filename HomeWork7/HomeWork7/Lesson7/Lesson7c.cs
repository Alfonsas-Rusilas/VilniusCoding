using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.Lesson7
{
    class Lesson7c
    {
        static void Main(string[] args)
        {
            // using System.Collections >>>>>>>
            // ArrayList:
            // Hashtable: porų sąrašas
            // Quene - eilė (first in, first in),    Stack (first in, last out),
            // SortedList: panašiai kaip surūšiuotas Hashtable 

            // using System.Collections.Generic >>>>>>>>>>>>
            // List<T>
            // LinkedList<T>
            // Dictionary<TKey, TValue>
            // SortedDictionary<TKey, TValue>
            // HashSet<T>       // kaip aibė su unikaliais elementais
            // SortedSet<T>     // surūšiuota aibė
            // Queue<T>
            // Stack<>

            // list.Add(123)
            // list.Insert(2, "kart du")
            // list.AddRange(other_list)
            // list.InsertRange(2, other_list)
            // list.Remove(element)
            // list.Count 
            /////////////////////// 7c   - collections

            List<int> main_list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                main_list.Add(rnd.Next(1, 100));
            }

            main_list.RemoveAll(LessThan80);

            int daugiau20 = 0;
            foreach (int item in main_list)
            {
                if (item % 2 == 0)
                {
                    Console.Write($" {item}");
                }
                if (item > 20)
                {
                    daugiau20++;
                }
            }

            Console.WriteLine($"Daugiau nei 20 = {daugiau20}");

            Console.WriteLine($"Sum = {main_list.Sum()}");

            Console.WriteLine($"Average = {main_list.Average()}");

            Console.WriteLine($"Count() = {main_list.Count()}");

            //List<int> sub_list = new List<int>() {10,20,30,40,50,60};

            //main_list.Add(9);
            //main_list.Insert(0,0);

            //PrintValues(main_list);

            //main_list.AddRange(sub_list);
            //PrintValues(main_list);

            //main_list.InsertRange(0, sub_list);
            //PrintValues(main_list);

            //main_list.Sort();
            //PrintValues(main_list);

            ////var teigiami = new Predicate<int>(isPositive);
            ////var filtered = main_list.FindAll(teigiami);
            //var filtered = main_list.FindAll(isPositive);


            //PrintValues(filtered);

            //main_list.RemoveAll(FindEven);
            //PrintValues(main_list);
        }


        static bool LessThan80(int val)
        {
            return val > 80;
        }

        static bool FindEven(int val)
        {
            return val % 2 == 0;
        }

        static void PrintValues(List<int> myList)
        {
            foreach (int i in myList)
                Console.Write($"   {i}");
            Console.WriteLine();
        }

        static void PrintValues(List<string> myList)
        {
            foreach (string i in myList)
                Console.Write($"   {i}");
            Console.WriteLine();
        }


        static string PrintStringArray(string[] str_array, string delimiter = " ")
        {
            string tmp = "";
            for (int m = 0; m < str_array.Length; m++)
            {
                tmp += " " + str_array[m];
            }
            return tmp;
        }

        static string PrintIntArray(int[] int_array, string delimiter = " ")
        {
            string tmp = "";
            for (int m = 0; m < int_array.Length; m++)
            {
                tmp += " " + int_array[m];
            }
            return tmp;
        }

    }
}
