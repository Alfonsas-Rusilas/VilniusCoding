using Lesson17.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Rinkiniai
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Delegate galima vertinti kaip nuorodas į funkcijas


            Table table = new Table();
            table.AddFood("Pie!");

            table.AddActionToTable(CustomFunction);

            table.DoAction(CustomAction);

            table.DoSpecialAction();

            List<int> data = new List<int>() { 0, 2, 3, 4, 5, 6, 7 };
            data.RemoveAll(TestOdd);
            data.FindAll(TestOdd);

            // -----------------------------------------------------------------------------------
            //public delegate void MyDelegate(string s);

        //    private MyDelegate myDelegate;
        //    private MyDelegate myDelegate1 = new MyDelegate(Console.WriteLine);
        //    private MyDelegate myDelegate3 = WriteToFile("ss");
        //// 
        //    myDelegate += WriteToFile(",,");
        //    myDelegate -= Console.WriteLine("");

        }



        private static bool TestOdd(int data)
        {
            return data % 2 == 1;
        }

        private static int CustomAction(int a, int b, bool Sum)
        {
            Console.WriteLine( $"CustomAction(int a={a}, int b={b}, bool Sum={Sum})" );
            return a+b;
        }

        private static int CustomFunction(int a, int b, bool Sum)
        {
            Console.WriteLine($"CustomAction(int a={a}, int b={b}, bool Sum={Sum})");
            return a + b;
        }

        private static void WriteToFile(string msg)
        {
            Console.WriteLine( "Write to File" + msg );
        }

    }
}
