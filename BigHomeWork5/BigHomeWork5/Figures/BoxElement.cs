using BigHomeWork5.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Figures
{
    internal class BoxElement
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Index { get; private set; }

        private ConsoleColor MyColor { get;  set; }

        private const string EmptyChar = " ";

        private bool IsCenter;

        public BoxElement(int x, int y, int position, ConsoleColor myColor,  bool IsCentr = false) //{ X = x; Y = y; IsCenter = IsCentr; }
        {
            X = x;
            Y = y;
            Index = position;
            MyColor = myColor;
            IsCenter = IsCentr;
        }


        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.BackgroundColor = MyColor;
            Console.Write(EmptyChar);
        }

        public void ClearRender()
        {
            Console.ResetColor();
            Console.SetCursorPosition(X, Y);
            String str = new string(' ', EmptyChar.Length);
            Console.Write(str);
        }

        internal bool CanMoveDown() => CupArray.DownArray2DValue(X, Y) == 0;

        internal void MoveDown()
        {
            ClearRender();
            Y++;
            Render();
        }

        internal bool CanMoveLeft() => CupArray.LeftArray2DValue(X, Y) == 0;

        internal void MoveLeft()
        {
            ClearRender();
            X--;
            Render();
        }

        internal bool CanMoveRight() => CupArray.RightArray2DValue(X, Y) == 0;

        internal void MoveRight()
        {
            ClearRender();
            X++;
            Render();
        }

        //internal string GetCoordinates() => $"X={X},Y={Y}";

        internal bool CanRotateRight()
        {
            bool b = CupArray.RotateRightArray2DValue(X, Y) == 0;
            return true;
        }
    }
}
