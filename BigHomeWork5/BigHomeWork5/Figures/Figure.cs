using BigHomeWork5.Enums;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigHomeWork5.Providers;

namespace BigHomeWork5.Figures
{
    internal class Figure
    {
        private List<BoxElement> Elements;
        public FiguresTypes FigureType { private set; get; }
        public FiguresAngle FigureAngle { private set; get; }
        public ConsoleColor FigureColor { private set; get; }
        public bool PreviewFigure { private set; get; }

        public Figure(FiguresTypes figureType, ConsoleColor color, bool previewFigure = false)
        {
            PreviewFigure = previewFigure;
            FigureType = figureType;
            FigureAngle = FiguresAngle.StartPosition;
            FigureColor = color;
            Elements = GenerateFigureElements(FigureType, color, PreviewFigure);
        }

        public void Render()
        {
            foreach (var box in Elements)
            {
                box.Render();
            }
        }

        public void ClearRender()
        {
            foreach (var box in Elements)
            {
                box.ClearRender();
            }
        }

        public bool CanMoveDown()
        {
            return Elements.All(s => s.CanMoveDown());
        }



        public bool CanMoveLeft()
        {
            return Elements.All(s => s.CanMoveLeft());
        }

        public bool CanMoveRight()
        {
            return Elements.All(s => s.CanMoveRight());
        }

        internal void MoveDown()
        {
            var BoxesOrdered = from boxes in Elements
                               orderby boxes.Y descending
                               select boxes;
            foreach (var box in BoxesOrdered)
            {
                box.MoveDown();
            }
        }

        internal void MoveLeft()
        {
            var BoxesOrdered = from boxes in Elements
                               orderby boxes.X 
                               select boxes;
            foreach (var box in BoxesOrdered)
            {
                box.MoveLeft();
            }
        }

        internal void MoveRight()
        {
            var BoxesOrdered = from boxes in Elements
                               orderby boxes.X descending
                               select boxes;
            foreach (var box in BoxesOrdered)
            {
                box.MoveRight();
            }
        }

        internal int FigureElementCoordinatesX(int index)
        {
            return Elements[index].X;
        }

        internal int FigureElementCoordinatesY(int index)
        {
            return Elements[index].Y;
        }

        internal bool CanRotateRight()
        {
            return Elements.All(s => s.CanRotateRight(FigureType, FigureAngle, Elements[1].X, Elements[1].Y));
        }

        internal void RotateRight()
        {
            ClearRender();
            foreach (var box in Elements)
            {
                box.RotateRight(FigureType, FigureAngle, Elements[1].X, Elements[1].Y);
            }
            FigureAngle = EnumsFunctions.GetNextFigureAngleEnumValue(FigureAngle);
        }

        internal void MergeWithBottom()
        {
            foreach (var box in Elements)
            {
                box.MergeWithBottom();
            }
        }

        internal bool NotMooved()
        {
            if (Elements[1].X == GameData.StartCenterX && Elements[1].Y == GameData.StartCenterY)
            {
                return true;
            } else
            {
                return false;
            }
        }

        internal List<BoxElement> GenerateFigureElements(FiguresTypes figureType, ConsoleColor color, bool NextFigure = false)
        {
            List<BoxElement> Elements = new List<BoxElement>();
            int rowNumber = (int)FiguresAngle.StartPosition;
            int FigureTypeRowInList = (int)figureType;
            var figure_row = FigureCoordinates.Coordinates[FigureTypeRowInList][rowNumber];
            int x = NextFigure ? GameData.NextStartCenterX : GameData.StartCenterX;
            int y = NextFigure ? GameData.NextStartCenterY : GameData.StartCenterY;
            Elements.Add(new BoxElement(x + figure_row.Item1.X, y + figure_row.Item1.Y, 0, color));
            Elements.Add(new BoxElement(x + figure_row.Item2.X, y + figure_row.Item2.Y, 1, color));
            Elements.Add(new BoxElement(x + figure_row.Item3.X, y + figure_row.Item3.Y, 2, color));
            Elements.Add(new BoxElement(x + figure_row.Item4.X, y + figure_row.Item4.Y, 3, color));

            return Elements;
        }

    }
}
