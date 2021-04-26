using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork12.Lesson12.Uzduotis_001.Interfaces;

namespace HomeWork12.Lesson12.Uzduotis_001
{
    class House : IPrintable, IRenderable
    {
        public void Print()
        {
            Console.WriteLine("House");
        }

        public void Render()
        {
            //
        }
    }
}
