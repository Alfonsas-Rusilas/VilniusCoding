using HomeWork12.Lesson12.Uzduotis_001.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Lesson12.Uzduotis_001
{

    class Dog : IPrintable, IMoveable
    {
        private int x;
        public int X { get { return x; } set { x = value; } }

        public void Print()
        {
            Console.WriteLine("Dog");
        }

        public void Move()
        {
            x++;
        }

    }
}
