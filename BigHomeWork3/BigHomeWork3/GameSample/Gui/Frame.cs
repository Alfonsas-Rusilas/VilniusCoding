using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Gui
{
    class Frame : GuiObject
    {

        public char RenderChar { get; set; }

        public Frame(int x, int y, int width, int height, char c) : base(x, y, width, height)
        {
            RenderChar = c;
        }

        //public void RenderEx()
        //{
        //    for (int i = X; i < X + Width; i++)
        //    {
        //        Console.SetCursorPosition(i, Y);
        //        Console.Write(RenderChar);
        //        Console.SetCursorPosition(i, Y + Height);
        //        Console.Write(RenderChar);
        //    }
        //    for (int i = Y; i <= Y + Height; i++)
        //    {
        //        Console.SetCursorPosition(X, i);
        //        Console.Write(RenderChar);
        //        Console.SetCursorPosition(X + Width, i);
        //        Console.Write(RenderChar);
        //    }
        //}


        //public void RenderFull()
        //{
        //    for (int v = 0; v < GameScreenHeight; v++)
        //    {
        //        for (int h = 0; h < Console.WindowWidth; h++)
        //        {
        //            Console.SetCursorPosition(h, v);
        //            if (((h >= x && h <= x + width) && (v == y || v == y + height)) || ((h == x || h == x + width) && (v >= y && v <= y + height)))
        //            {
        //                Console.Write(RenderChar);
        //            } else
        //            {
        //                Console.Write("");
        //            }
        //        }

        //    }
        //}

        public void Render()
        {
            for (int v = Y; v <= Y + Height; v++)
            {
                for (int h = X; h <= X + Width; h++)
                {
                    Console.SetCursorPosition(h, v);
                    if (((h >= X && h <= X + Width) && (v == Y || v == Y + Height)) || ((h == X || h == X + Width) && (v >= Y && v <= Y + Height)))
                    {
                        Console.Write(RenderChar);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

            }

        }


        public void ClearRender()
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
