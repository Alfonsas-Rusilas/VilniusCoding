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
        private FiguresTypes FigureType;
        private FiguresAngle FigureAngle;

        public Figure(FiguresTypes figureType, ConsoleColor color)
        {
            FigureType = figureType;
            FigureAngle = FiguresAngle.StartPosition;
            Elements = FigureFactory.GenerateFigureElements(FigureType, color);
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


        //internal bool CanRotateRight()
        //{
        //    return Elements.All(s => s.CanRotateRight());
        //}

        internal bool CanRotateRight()
        {
            //return Elements.All(s => s.CanRotateRight());
            bool can = false;
            int CentrX = Elements[1].X;
            int CentrY = Elements[1].Y;

            CupArray.RotateRightArray2DValue(CentrX, CentrY, FigureType);

            return can;
        }

    }
}
