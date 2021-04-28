using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13.StaticUzduotys
{
    class StaticClass3
    {
        public double Pi = 3.1415;
        private string sostine = "Helsinky";
        public static int MoonCount = 1;
        private static string president = "AIG";

        public StaticClass3()
        {
            //
        }

        public void ShowPi()
        {
            Console.WriteLine("StaticClass3: " + Pi);
        }

        private void ShowSostine()
        {
            Console.WriteLine("StaticClass3: " + sostine);
        }

        public static void ShowMoonCount()
        {
            Console.WriteLine("StaticClass3: " + MoonCount);
        }

        private static void ShowPresident()
        {
            Console.WriteLine("StaticClass3: " + president);
        }

        public void CallMembers_StaticClass3()
        {
            ShowPi();
            ShowSostine();
            ShowMoonCount();
            ShowPresident();
            Console.WriteLine("------------------------");
        }
    }
}
