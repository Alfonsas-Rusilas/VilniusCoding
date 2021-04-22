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


        public void RenderFull()
        {
            for (int v = 0; v < Console.WindowHeight; v++)
            {
                for (int h = 0; h < Console.WindowWidth; h++)
                {
                    Console.SetCursorPosition(h, v);
                    if (((h >= x && h <= x + width) && (v == y || v == y + height)) || ((h == x || h == x + width) && (v >= y && v <= y + height)))
                    {
                        Console.Write(_char);
                    } else
                    {
                        Console.Write("");
                    }
                }

            }
        }

        public void RenderEx()
        {
            for (int v = y; v <= y+height; v++)
            {
                for (int h = x; h <= x+width; h++)
                {
                    Console.SetCursorPosition(h, v);
                    if (((h >= x && h <= x + width) && (v == y || v == y + height)) || ((h == x || h == x + width) && (v >= y && v <= y + height)))
                    {
                        Console.Write(_char);
                    }
                    else
                    {
                        Console.Write("");
                    }
                }

            }
        }

        public void Render()
        {
            for (int i = x; i < x+width; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write(_char);
                Console.SetCursorPosition(i, y + height);
                Console.Write(_char);
            }
            for (int i = y; i <= y + height; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(_char);
                Console.SetCursorPosition(x + width, i);
                Console.Write(_char);
            }
        }
    }
}
