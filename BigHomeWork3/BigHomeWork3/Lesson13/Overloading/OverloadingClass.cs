using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13.Overloading
{
    class OverloadingClass
    {
        private int X = 0;

        public OverloadingClass()
        {
            Console.WriteLine("OverloadingClass()");
        }

        public OverloadingClass(string str)
        {
            Console.WriteLine("OverloadingClass(string str)");
        }

        public OverloadingClass(Button btn)
        {
            Console.WriteLine("OverloadingClass(Button btn)");
        }

        public void Move()
        {
            X++;
        }

        public void Move(int forvard)
        {
            X = X + forvard;
        }

        public void Print()
        {
            Console.WriteLine("Printing..");
        }

        public void Print(string str)
        {
            Console.WriteLine("Printing.." + str);
        }

        public void Test(int count)
        {
            Console.WriteLine("Testing twice");
        }

        public void Test()
        {
            Console.WriteLine("Testing once");
        }

        public void Debug()
        {
            Console.WriteLine("Simple Debug");
        }

        public void Debug(bool deep)
        {
            Console.WriteLine("Deep debug");
            Console.WriteLine("===============");
            Console.WriteLine("X= " + this.X);
            Console.WriteLine("this.toString()=" + this.ToString());
        }

    }
}
