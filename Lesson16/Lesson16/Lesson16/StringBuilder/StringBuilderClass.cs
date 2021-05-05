using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Lesson16.StringBuilder2
{
    class StringBuilderClass
    {
        static void Main(string[] args)
        {
            StringBuilder myString = new StringBuilder("Pirma eilutė\n");
            myString.Append("Antra eilutė\n");

            int len = myString.Length;

            myString.Append("Trečia eilutė\n");
            myString.AppendLine("Ketvirta eilutė");
            //myString.AppendFormat("Ketvirta eilutė");

            object[] var4 = { 3, 44, 'X' };
            myString.AppendFormat("Formatas: {0}, {1}, {2}", var4);
            Console.WriteLine(myString.ToString());

            myString.Insert(0, "Įterpiu eilutę.");
            Console.WriteLine(myString.ToString());

            myString.Replace('a', 'A');
            Console.WriteLine(myString.ToString());

            myString.Remove(0, 15);
            Console.WriteLine(myString.ToString());

            char[] some = new char[4];
            myString.CopyTo(0, some, 0, 3);
            Console.WriteLine(some);

        }
    }
}
