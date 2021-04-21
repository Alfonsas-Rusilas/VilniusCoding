using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Game
{
    class Unit
    {
        protected int X;
        protected int Y;
        protected string Name;

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
