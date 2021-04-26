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
        private bool IsCenter;

        public TextLine(int x, int y, int width, string msg, bool isCenter = false) : base(x,y,width)
        {
            this.data = msg;
            IsCenter = isCenter;
        }

        //public void SetCenter(bool isCenter)
        //{
        //    IsCenter = isCenter;
        //}

        public void Render()
        {
            if (IsCenter)
            {
                Console.SetCursorPosition((Console.WindowWidth - data.Length) / 2, y);
            } 
            else
            {
                Console.SetCursorPosition(x, y);
            }
            Console.Write(data);
        }


    }
}
