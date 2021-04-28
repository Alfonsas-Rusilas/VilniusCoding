using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13.StaticUzduotys
{
    class StaticClass2
    {
        public double Pi = 3.1415;
        private string sostine = "Berlynas";

        public StaticClass2()
        {
            //
        }

        public void ShowPi()
        {
            Console.WriteLine("StaticClass2: " + Pi);
        }

        private void ShowSostine()
        {
            Console.WriteLine("StaticClass2: " + sostine);
        }

        public void CallMembers_StaticClass2()
        {
            ShowPi();
            ShowSostine();
            Console.WriteLine("------------------------");
        }
    }
}
