using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class GuiObject
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        //private int ConsoleWidth = Console.WindowWidth;
        //private int ConsoleHeight = Console.WindowHeight;

        public GuiObject(int x, int y, int width, int height = 1)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        //public void SetConsoleSize(int w, int h)
        //{
        //    ConsoleWidth = w;
        //    ConsoleHeight = h;
        //}

        //public int GetConsoleWidth()
        //{
        //    return ConsoleWidth;
        //}

        //public int GetConsoleHeight()
        //{
        //    return ConsoleHeight;
        //}
    }
}
