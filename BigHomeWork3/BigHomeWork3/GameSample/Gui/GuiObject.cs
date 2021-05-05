using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Gui
{
    abstract class GuiObject
    {
        public int X {get; set;}
        public int Y {get; set;}
        public int Width {get; set;}
        public int Height {get; set;}

        public GuiObject(int x, int y, int width, int height = 1)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        abstract public void Render();
               

    }
}
