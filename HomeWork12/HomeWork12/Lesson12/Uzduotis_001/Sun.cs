using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork12.Lesson12.Uzduotis_001.Interfaces;

namespace HomeWork12.Lesson12.Uzduotis_001
{
    class Sun : IPrintable, IGlows, IMoveable
    {
        private int x;
        public int X { get { return x; } set { x = value; } }

        public void Print()
        {
            Console.WriteLine("Sun");
        }

        public void MakeGlow()
        {
            //
        }

        public void Move()
        {
            x++;
        }
    }
}
