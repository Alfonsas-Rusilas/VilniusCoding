using BigHomeWork5.Enums;
using BigHomeWork5.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Providers
{
    class FigureFactory2
    {
        private static int StartingPointX = 4;
        private static int StartingPointY = 2;    

        private static (int X, int Y, bool center)[] ICoordinates = new[] { (3, 1, false), (4, 1, true), (5, 1, false), (6, 1, false) };
        private static (int X, int Y, bool center)[] OCoordinates = new[] { (4, 1, false), (5, 1, true), (4, 2, false), (5, 2, false) };
        private static (int X, int Y, bool center)[] ZCoordinates = new[] { (3, 1, false), (4, 1, true), (4, 2, false), (5, 2, false) };
        private static (int X, int Y, bool center)[] SCoordinates = new[] { (3, 2, false), (4, 2, true), (4, 1, false), (5, 1, false) };
        private static (int X, int Y, bool center)[] TCoordinates = new[] { (3, 1, false), (4, 1, true), (5, 1, false), (4, 2, false) };
        private static (int X, int Y, bool center)[] LCoordinates = new[] { (-1, 0, false), (0, 0, true), (1, 0, false), (1, -1, false) };
        private static (int X, int Y, bool center)[] JCoordinates = new[] { (3, 2, false), (4, 2, true), (5, 2, false), (3, 1, false) };


        //private static (int X, int Y, bool center)[] ICoordinates = new[] { (3, 1, false), (4, 1, true), (5, 1, false), (6, 1, false) };
        //private static (int X, int Y, bool center)[] OCoordinates = new[] { (4, 1, false), (5, 1, true), (4, 2, false), (5, 2, false) };
        //private static (int X, int Y, bool center)[] ZCoordinates = new[] { (3, 1, false), (4, 1, true), (4, 2, false), (5, 2, false) };
        //private static (int X, int Y, bool center)[] SCoordinates = new[] { (3, 2, false), (4, 2, true), (4, 1, false), (5, 1, false) };
        //private static (int X, int Y, bool center)[] TCoordinates = new[] { (3, 1, false), (4, 1, true), (5, 1, false), (4, 2, false) };
        //private static (int X, int Y, bool center)[] LCoordinates = new[] { (3, 2, false), (4, 2, true), (5, 2, false), (5, 1, false) };
        //private static (int X, int Y, bool center)[] JCoordinates = new[] { (3, 2, false), (4, 2, true), (5, 2, false), (3, 1, false) };

        internal static List<BoxElement> GenerateFigureElements(FiguresTypes figureType, ConsoleColor color)
        {
            List<BoxElement> Elements = new List<BoxElement>();
            //(int X, int Y, bool center)[] JCoordinates = new[]();



            switch (figureType)
            {
                case FiguresTypes.I:
                    //foreach (var item in ICoordinates)
                    //{
                    //    Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    //}
                    for (int i = 0; i < ICoordinates.Length; i++)
                    {
                        Elements.Add(new BoxElement(ICoordinates[i].X, ICoordinates[i].Y, i, color, ICoordinates[i].center));
                    }
                    break;
                case FiguresTypes.O:
                    //foreach (var item in OCoordinates)
                    //{
                    //    Elements.Add(new BoxElement(item.X, item.Y, color, item.center));
                    //}
                    for (int i = 0; i < OCoordinates.Length; i++)
                    {
                        Elements.Add(new BoxElement(OCoordinates[i].X, OCoordinates[i].Y, i, color, OCoordinates[i].center));
                    }
                    break;
                case FiguresTypes.L:
                    foreach (var item in LCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, 1,color, item.center));
                    }
                    break;
                case FiguresTypes.T:
                    foreach (var item in TCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, 1,color, item.center));
                    }
                    break;
                case FiguresTypes.Z:
                    foreach (var item in ZCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, 1,color, item.center));
                    }
                    break;
                case FiguresTypes.S:
                    foreach (var item in SCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, 1,color, item.center));
                    }
                    break;
                case FiguresTypes.J:
                    foreach (var item in JCoordinates)
                    {
                        Elements.Add(new BoxElement(item.X, item.Y, 1,color, item.center));
                    }
                    break;
                default:
                    break;
            }
            return Elements;
        }
    }
    }
