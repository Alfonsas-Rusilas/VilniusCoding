using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class Frame : GuiObject
    {

        public char RenderChar { get; set; }

        public Frame(int x, int y, int width, int height, char c) : base(x, y, width, height)
        {
            RenderChar = c;
        }

        public void Render()
        {
            for (int i = x; i < x + width; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write(RenderChar);
                Console.SetCursorPosition(i, y + height);
                Console.Write(RenderChar);
            }
            for (int i = y; i <= y + height; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(RenderChar);
                Console.SetCursorPosition(x + width, i);
                Console.Write(RenderChar);
            }
        }


        //public void RenderFull()
        //{
        //    for (int v = 0; v < Console.WindowHeight; v++)
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

        //public void RenderEx()
        //{
        //    for (int v = y; v <= y+height; v++)
        //    {
        //        for (int h = x; h <= x+width; h++)
        //        {
        //            Console.SetCursorPosition(h, v);
        //            if (((h >= x && h <= x + width) && (v == y || v == y + height)) || ((h == x || h == x + width) && (v >= y && v <= y + height)))
        //            {
        //                Console.Write(RenderChar);
        //            }
        //            else
        //            {
        //                Console.Write("");
        //            }
        //        }

        //    }
        //}


    }
}
