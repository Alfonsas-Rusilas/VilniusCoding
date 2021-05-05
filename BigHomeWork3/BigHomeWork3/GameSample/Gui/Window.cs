using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Windows
{
    class Window : GuiObject
    {
        private Frame border;

        public Window(int x, int y, int width, int height) : base(x, y, width, height)
        {
            border = new Frame(x, y, width, height, '%');
        }

        public virtual void Render()
        {
            border.Render();
        }
    }
}
