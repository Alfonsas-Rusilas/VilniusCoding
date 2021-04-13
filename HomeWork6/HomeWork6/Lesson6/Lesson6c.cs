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
