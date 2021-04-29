using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Unit
{
    class Unit
    {
        //protected int X;
        public int X { set; get; }
        public int Y { set; get; }

        public string Name { set; get; }

        public Unit(string name, int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Unit: {Name}, {X}x{Y}");
        }

    }
}
