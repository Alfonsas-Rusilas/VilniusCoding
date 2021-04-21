using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Game
{
    class Hero: Unit
    {
        //private int x;
        //private int y;
        //private string name;
               

        public Hero(string name, int x, int y) : base(name, x, y)
        {
            //this.x = x;
            //this.y = y;
            //this.name = name;
        }

        public void MoveRight()
        {
            X++;
        }

        public void MoveLeft()
        {
            X--;
        }

        //public void PrintInfo()
        //{
        //    Console.WriteLine($"Hero: {name}, {x}x{y}");
        //}

    }
}
