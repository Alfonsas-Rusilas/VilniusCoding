using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork9.GameSample.Game;

namespace HomeWork9.GameSample.Game
{
    class GameScreen
    {
        private int width;
        private int height;
        private int y;
        private string name;


        public GameScreen(int id, string name, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;

        }
    }
}
