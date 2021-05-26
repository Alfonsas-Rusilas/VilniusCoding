using BigHomeWork5.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Figures
{
    class BoxElement
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        private const string Char = " ";

        public BoxElement(int x, int y)
        {
            X = x;
            Y = y;
        }


        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Char);
        }

        public void ClearRender()
        {
            Console.ResetColor();
            Console.SetCursorPosition(X, Y);
            String str = new string(' ', Char.Length);
            Console.Write(str);
        }


        internal void MoveUp()
        {
            ClearRender();
            Y--;
            Render();
        }

        internal void MoveDown()
        {
            ClearRender();
            Y++;
            Render();
        }

        internal bool CanMoveDown()
        {
            return Y < CupWalls.DownSideValue(X);
        }

        internal void MoveLeft()
        {
            ClearRender();
            X--;
            Render();
        }

        internal bool CanMoveLeft()
        {
            return X > CupWalls.LeftSideValue(Y);
        }

        internal bool CanMoveRight()
        {
            return X < CupWalls.LeftSideValue(Y);
        }

        internal void MoveRight()
        {
            ClearRender();
            X++;
            Render();
        }

        internal string GetCoordinates()
        {
            return $"X={X},Y={Y}";
        }
    }
}
