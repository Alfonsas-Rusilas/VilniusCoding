using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13.Overloading
{
    class MainOverloading
    {

        public static void Main()
        {
            OverloadingClass clas2 = new OverloadingClass();

            OverloadingClass clas3 = new OverloadingClass(new Button(1, 1, 10, 10, "Pavadinimas"));

            OverloadingClass clas1 = new OverloadingClass("some string");
            clas1.Move();
            clas1.Move(2);
            clas1.Print();
            clas1.Print(" Ula la");
            clas1.Test();
            clas1.Test(2);
            clas1.Debug();
            clas1.Debug(true);

        }
    }
}
