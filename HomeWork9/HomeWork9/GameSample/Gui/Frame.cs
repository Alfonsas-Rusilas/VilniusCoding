using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class Frame : GuiObject
    {
        private char _char;
        public Frame(int x, int y, int width, int height, char c) : base(x, y, width, height)
        {
            _char = c;
        }


        public void Render()
        {
            //Console.Clear();
            // width, height

            Console.SetCursorPosition(x, y);
            for (int i = x; i < width; i++)
            {
                //Console.SetCursorPosition(x, y);
                Console.Write(_char);
            }
                        
            for (int i = 2; i < height; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(_char);
                Console.SetCursorPosition(width-1, i);
                Console.Write(_char);
            }

            for (int i = 1; i < width; i++)
            {
                Console.Write(_char);
            }

        }
    }
}
