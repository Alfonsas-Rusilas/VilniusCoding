using Lesson18.Uzduotis1;
using Lesson18.Uzduotis2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.Uzduotis2
{
    class Main5
    {
        static void Main()
        {
            int a = 5;
            Console.WriteLine("Kvadratas: " + a.PowerTwo());

            Student st = new Student() { Id = 0, Name = "Kestas", Age = 30, AvarageMark = 6.1, IsGettingTuition = true };
            string str = st.PowerStudentName();
            Console.WriteLine("Klases Student Objekto Name: " + str);



        }
    }
}
