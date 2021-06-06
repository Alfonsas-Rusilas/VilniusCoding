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
            Elements = FigureFactory.GenerateFigureElements(FigureType, color, PreviewFigure);
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

    }
}
