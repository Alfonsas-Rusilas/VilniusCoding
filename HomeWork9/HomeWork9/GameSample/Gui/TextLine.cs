using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class TextLine : GuiObject
    {
        protected string data;
        public TextLine(int x, int y, int width, string msg) : base(x,y,width,1)
        {
            this.data = msg;
        }

        public void Render()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(data);
        }
    }
}
