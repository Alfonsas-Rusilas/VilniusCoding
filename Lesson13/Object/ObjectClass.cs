using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13
{
    class ObjectClass
    {
        public static void Main()
        {
            Button btn1 = new Button(1,1,5,5,"Name");

            if (btn1.GetType() == typeof(Button))
            {
                // is eq.
            }

            //string str = btn1 as string; 
        }

    }
}
