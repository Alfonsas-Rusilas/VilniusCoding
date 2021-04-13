using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Lesson6
{
    class Lesson6c
    {
        static void Main(string[] args)
        {
            //
            ParamsTesting(44, new double[] { 1.2, 2.2, 3.2}, "pirmas", "antras", "trečias");
            //
        }

        static void ParamsTesting(int i, double[] db, params string[] rest)
        {
            Console.WriteLine($"Parametas 1: {i}");
            string temp = "";
            foreach (var item in db)
            {
                temp += item + " ";
            }
            Console.WriteLine($"Parametas 2: {temp}");
            temp = "";
            foreach (var item in rest)
            {
                temp += item + " ";
            }
            Console.WriteLine($"Parametas 3: {temp}");
        }

        static string PrintArray(string[] str_array, string delimiter = " ")
        {
            string tmp = "";
            for (int m = 0; m < str_array.Length; m++)
            {
                tmp += " " + str_array[m];
            }
            return tmp;
        }
    }
}
