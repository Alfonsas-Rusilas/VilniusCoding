using BigHomeWork5.Enums;
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
        public int BoxIndex { get; private set; }

        private ConsoleColor MyColor { get;  set; }

        private const string EmptyChar = " ";


        public BoxElement(int x, int y, int position, ConsoleColor myColor) 
        {
            X = x;
            Y = y;
            BoxIndex = position;
            MyColor = myColor;
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

        internal bool CanMoveDown() => TetrisArray.DownArray2DValue(X, Y) == 0;

        internal void MoveDown()
        {
            ClearRender();
            Y++;
            Render();
        }

        internal bool CanMoveLeft() => TetrisArray.LeftArray2DValue(X, Y) == 0;

        internal void MoveLeft()
        {
            ClearRender();
            X--;
            Render();
        }

        internal bool CanMoveRight() => TetrisArray.RightArray2DValue(X, Y) == 0;

        internal void MoveRight()
        {
            ClearRender();
            X++;
            Render();
        }

         internal bool CanRotateRight(FiguresTypes figureType, FiguresAngle figureAngle, int centerX, int centerY)
        {
            int rowNumber = (int)figureAngle + 1;
            if (rowNumber > 3) rowNumber = 0;

            int FigureTypeRowInList = (int)figureType;
            var figure_row = FigureCoordinates.Coordinates[FigureTypeRowInList][rowNumber];

            int nextX = 88;
            int nextY = 88;

            switch (BoxIndex)
            {
                case 0:
                    nextX = centerX + figure_row.Item1.X;
                    nextY = centerY + figure_row.Item1.Y;
                    break;
                case 1:
                    nextX = centerX + figure_row.Item2.X;
                    nextY = centerY + figure_row.Item2.Y;
                    break;
                case 2:
                    nextX = centerX + figure_row.Item3.X;
                    nextY = centerY + figure_row.Item3.Y;
                    break;
                case 3:
                    nextX = centerX + figure_row.Item4.X;
                    nextY = centerY + figure_row.Item4.Y;
                    break;
            }
            return TetrisArray.Array2DValue(nextX, nextY) == 0;
        }

        internal void RotateRight(FiguresTypes figureType, FiguresAngle figureAngle, int x, int y)
        {
            int rowNumber = (int)figureAngle + 1;
            if (rowNumber > 3) rowNumber = 0;

            int FigureTypeRowInList = (int)figureType;
            var figure_row = FigureCoordinates.Coordinates[FigureTypeRowInList][rowNumber];

            switch (BoxIndex)
            {
                case 0:
                    X = x + figure_row.Item1.X;
                    Y = y + figure_row.Item1.Y;
                    break;
                case 1:
                    X = x + figure_row.Item2.X;
                    Y = y + figure_row.Item2.Y;
                    break;
                case 2:
                    X = x + figure_row.Item3.X;
                    Y = y + figure_row.Item3.Y;
                    break;
                case 3:
                    X = x + figure_row.Item4.X;
                    Y = y + figure_row.Item4.Y;
                    break;
            }
            Render();
        }

        internal void MergeWithBottom()
        {
            TetrisArray.MergeElementWithBottom(X, Y, (int)MyColor);
        }
    }
}
