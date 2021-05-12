using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Gui
{
    class TextLine : GuiObject
    {
        public string Label { get; set; }
        private bool IsCenter;

        public TextLine(int x, int y, int width, string msg, bool isCenter = false) : base(x,y,width)
        {
            this.Label = msg;
            IsCenter = isCenter;
        }


        public override void Render()
        {
            if (IsCenter)
            {
                Console.SetCursorPosition((Console.WindowWidth - Label.Length) / 2, Y);
            } 
            else
            {
                Console.SetCursorPosition(X, Y);
            }
            Console.Write(Label);
        }


    }
}
