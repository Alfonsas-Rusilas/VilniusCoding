using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Speros
{
    delegate void dePrint1();

    class PrintStr
    {
        public event dePrint1 Readkey;
        public void Print1(string i)
        {
            Console.WriteLine("PrintStr:" + i + " .. ir dabar dePrint1.Readkey();");
            Readkey();
        }
    }
    class Program
    {
        public static void Print1()
        {
            Console.WriteLine("Program.Print1 - Console.ReadKey()");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PrintStr printstr = new PrintStr();
            printstr.Readkey += new dePrint1(Program.Print1);
            printstr.Print1("1");
            printstr.Print1("2");
            printstr.Print1("Trys");

            Console.Write("Įveskite sveiką skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

        }

    }
}
