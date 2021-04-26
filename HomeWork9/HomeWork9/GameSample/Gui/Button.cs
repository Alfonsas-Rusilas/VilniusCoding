using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class Button : GuiObject
    {
        //private Frame activeFrame;
        //private Frame notActiveFrame;
        private Frame frame;
        private TextLine textLine;
        public bool IsActive { set; get; } = false;
        private const char activeChar = '#';
        private const char notActiveChar = '*';

        public Button(int x, int y, int width, int height, string name) : base(x, y, width, height)
        {
            //activeFrame = new Frame(x,y,width,height, activeChar);
            //notActiveFrame = new Frame(x, y, width, height, notActiveChar);
            frame = new Frame(x, y, width, height, notActiveChar);

            if (name.Length > width - 2)
            {
                textLine = new TextLine(x + 1, y + height / 2, width - 2, name.Substring(0, width - 2));
            }
            else
            {
                int temp = width - 2;
                temp = (temp - name.Length)/ 2;
                textLine = new TextLine(x + 1 + temp, y + height / 2, width - 2, name);
            }
        }

        public void SetActive(bool isActive)
        {
            IsActive = isActive;
        }


        public void Render()
        {
            if (IsActive)
            {
                frame.RenderChar = activeChar;
            } 
            else
            {
                frame.RenderChar = notActiveChar;
            }
            frame.Render();
            textLine.Render();
        }
    }
}
