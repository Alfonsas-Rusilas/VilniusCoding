using BigHomeWork4.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Gui
{
    class Frame : GuiObject
    {
        public char FrameRenderChar { get; set; }

        public Frame(int x, int y, int width, int height, char c = '*') : base(x, y, width, height)
        {
            FrameRenderChar = c;
        }

        public override void Render()
        {
            for (int v = Y; v <= Y + Height; v++)
            {
                for (int h = X; h <= X + Width; h++)
                {
                    Console.SetCursorPosition(h, v);
                    if (((h >= X && h <= X + Width) && (v == Y || v == Y + Height)) || ((h == X || h == X + Width) && (v >= Y && v <= Y + Height)))
                    {
                        Console.Write(FrameRenderChar);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

            }

        }

        public void ClearFrameRender()
        {
            for (int v = Y; v <= Y + Height; v++)
            {
                for (int h = X; h <= X + Width; h++)
                {
                    Console.SetCursorPosition(h, v);
                    Console.Write(" ");
                }
            }
        }

    }
}
