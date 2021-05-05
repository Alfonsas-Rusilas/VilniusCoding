using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13.StaticUzduotys
{
    class StaticClass1
    {
        public static double Pi = 3.1415;
        private static string sostine = "Vilnius";

        public StaticClass1()
        {
            //
        }

        public static void ShowPi()
        {
            Console.WriteLine("StaticClass1: " + Pi);
        }

        private static void ShowSostine()
        {
            Console.WriteLine("StaticClass1: " + sostine);
        }

        public void CallMembers_StaticClass1()
        {
            ShowPi();
            ShowSostine();
            Console.WriteLine("------------------------");
        }


    }
}
