using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class Window : GuiObject
    {
        private Frame border;

        public Window(int x, int y, int width, int heght, char renderChar): base(x,y,width,heght)
        {
            border = new Frame(x, y, width, height, renderChar);
        }

        public void Render()
        {
            border.Render();
        }

    }
}
