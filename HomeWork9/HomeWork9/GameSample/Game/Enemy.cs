using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Game
{
    class Enemy
    {
        private int id;
        private int x;
        private int y;
        private string name;


        public Enemy(int id, string name, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;
            
        }

        public void MoveDown()
        {
            y--;
        }

        public int GetId()
        {
            return id;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Enemy: {name}, id={id}, x={x}, y={y}");
        }
    }


}
