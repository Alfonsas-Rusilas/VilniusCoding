using BigHomeWork5.Enums;
using BigHomeWork5.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Providers
{
    internal static class FigureFactory
    {
        //private static int[] BoxCoordinates = new int[] { 4, 1, 5, 1, 4, 2, 5, 2 };
        //private static Tuple<int, int>[] BoxCoordinates2 = new Tuple<int, int>[] { 4, 1, 5, 1, 4, 2, 5, 2 };
        //private static Point[] BoxCoordinates = { new Point(4, 1), new Point(5, 1), new Point(4, 2), new Point(5, 2) };
        //TypeOf()

        

        private static (int X, int Y, bool center)[] BoxCoordinates = new[] { (4,1,false), (5,1,true), (4,2,false), (5,2,false) };
        private static (int X, int Y, bool center)[] LineCoordinates = new[] { (3,1,false), (4,1,true), (5,1,false), (6,1,false) };
        private static (int X, int Y, bool center)[] TCoordinates = new[] { (3,1,false), (4,1,true), (5,1,false), (4,2,false) };
        private static (int X, int Y, bool center)[] LCoordinates = new[] { (3,1,false), (4,1,false), (5,1,true), (6,1,false), (6,2,false) };
        private static (int X, int Y, bool center)[] ZCoordinates = new[] { (3,1,false), (4,1,true), (4,2,false), (5,2,false) };
        private static (int X, int Y, bool center)[] SCoordinates = new[] { (3,2,false), (4,2,true), (4,1,false), (5,1,false) };


        //var coords2 = new (int X, int Y)[] { (50, 350), (50, 650), (450, 650) };

        internal static List<BoxElement> GenerateFigureElements(FiguresTypes figureType, ConsoleColor color)
        {
            List<BoxElement> Elements = new List<BoxElement>();

            switch (figureType)
            {
                case FiguresTypes.Line:
                    foreach (var item in LineCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    }
                    break;
                case FiguresTypes.Box:
                    foreach (var item in BoxCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    }
                    break;
                case FiguresTypes.L:
                    foreach (var item in LCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    }
                    break;
                case FiguresTypes.T:
                    foreach (var item in TCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    }
                    break;
                case FiguresTypes.Z:
                    foreach (var item in ZCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    }
                    break;
                case FiguresTypes.S:
                    foreach (var item in SCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    }
                    break;
                default:
                    break;
            }
            return Elements;
        }

    }
}
