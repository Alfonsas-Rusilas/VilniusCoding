using BigHomeWork5.Enums;
using BigHomeWork5.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Providers
{
    internal static class FigureFactory
    {
        private static int StartCenterX = 4;
        private static int StartCenterY = 2;

        internal static List<((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[]> Coordinates =
            new List<((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[]>()
            {
             new[] { //ICoordinates
            ( (-1,0),(0,0),(1,0),(2,0) ),
            ( (0,-1),(0,0),(0,1),(0,2) ),
            ( (1,0),(0,0),(-1,0),(-2,0) ),
            ( (0,1),(0,0),(0,-1),(0,-2) )
            },
             new[] { //OCoordinates
            ( (0,-1),(0,0),(1,0),(1,-1) ),
            ( (0,-1),(0,0),(1,0),(1,-1) ),
            ( (0,-1),(0,0),(1,0),(1,-1) ),
            ( (0,-1),(0,0),(1,0),(1,-1) )
            },
             new[] { //ZCoordinates 
            ( (-1,-1),(0,0),(0,-1),(1,0) ),
            ( (1,-1),(0,0),(1,0),(0,1) ),
            ( (1,1),(0,0),(0,1),(-1,0) ),
            ( (-1,1),(0,0),(-1,0),(0,-1) )
            },
             new[] { //SCoordinates
            ( (-1,0),(0,0),(0,-1),(1,-1) ),
            ( (0,-1),(0,0),(1,0),(1,1) ),
            ( (1,0),(0,0),(0,1),(-1,1) ),
            ( (0,1),(0,0),(-1,0),(-1,-1) )
            },
             new[] { //TCoordinates
            ( (-1,0),(0,0),(1,0),(0,-1) ),
            ( (0,-1),(0,0),(0,1),(1,0) ),
            ( (1,0),(0,0),(-1,0),(0,1) ),
            ( (0,1),(0,0),(0,-1),(-1,0) )
            },
             new[] { //LCoordinates
            ( (-1,0),(0,0),(1,0),(1,-1) ),
            ( (0,-1),(0,0),(0,1),(1,1) ),
            ( (1,0),(0,0),(-1,0),(-1,1) ),
            ( (0,1),(0,0),(0,-1),(-1,-1) )
            },
             new[] { //JCoordinates
            ( (1,0),(0,0),(-1,0),(-1,-1) ),
            ( (0,1),(0,0),(0,-1),(1,-1) ),
            ( (-1,0),(0,0),(1,0),(1,1) ),
            ( (0,-1),(0,0),(0,1),(-1,1) )
            }
    };

        internal static List<BoxElement> GenerateFigureElements(FiguresTypes figureType, ConsoleColor color)
        {
            List<BoxElement> Elements = new List<BoxElement>();
            int rowNumber = (int)FiguresAngle.StartPosition;
            int FigureTypeRowInList = (int)figureType;
            var figure_row = Coordinates[FigureTypeRowInList][rowNumber];

            Elements.Add(new BoxElement(StartCenterX + figure_row.Item1.X, StartCenterY + figure_row.Item1.Y, 0, color));
            Elements.Add(new BoxElement(StartCenterX + figure_row.Item2.X, StartCenterY + figure_row.Item2.Y, 1, color));
            Elements.Add(new BoxElement(StartCenterX + figure_row.Item3.X, StartCenterY + figure_row.Item3.Y, 2, color));
            Elements.Add(new BoxElement(StartCenterX + figure_row.Item4.X, StartCenterY + figure_row.Item4.Y, 3, color));

            return Elements;
        }



    }










    //private static int[] BoxCoordinates = new int[] { 4, 1, 5, 1, 4, 2, 5, 2 };
    //private static Tuple<int, int>[] BoxCoordinates2 = new Tuple<int, int>[] { 4, 1, 5, 1, 4, 2, 5, 2 };
    //private static Point[] BoxCoordinates = { new Point(4, 1), new Point(5, 1), new Point(4, 2), new Point(5, 2) };
    //TypeOf()
    //var coords2 = new (int X, int Y)[] { (50, 350), (50, 650), (450, 650) };
    //private static (string,  (int X, int Y)[]) LCoordinates2 =  new[] { (-1, 0, false), (0, 0, true), (1, 0, false), (1, -1, false) };
    // private static List<Tuple<int, string>> list = new List<Tuple<int, string>>();
    //private static (int X, int Y, bool center)[] ICoordinates = new[] { (3, 1, false), (4, 1, true), (5, 1, false), (6, 1, false) };
    //private static (int X, int Y, bool center)[] OCoordinates = new[] { (4,1,false), (5,1,true), (4,2,false), (5,2,false) };
    //private static (int X, int Y, bool center)[] ZCoordinates = new[] { (3, 1, false), (4, 1, true), (4, 2, false), (5, 2, false) };
    //private static (int X, int Y, bool center)[] SCoordinates = new[] { (3, 2, false), (4, 2, true), (4, 1, false), (5, 1, false) };
    //private static (int X, int Y, bool center)[] TCoordinates = new[] { (3,1,false), (4,1,true), (5,1,false), (4,2,false) };

    //private static (int X, int Y, bool center)[] LCoordinates_x = new[] { (-1,0,false), (0,0,true), (1,0,false), (1,-1,false) };
    //   private static readonly (string, string)[] test = { ("foo", "bar"), ("baz", "foz") };
    //private static (int X, int Y, bool center)[] JCoordinates = new[] { (3,2,false), (4,2,true), (5,2,false), (3,1,false) };
    //(int X, int Y, bool center)[] JCoordinates = new[]();

    //var tuple = new Tuple<string, string[], int, int[]>("perl", new string[] { "java", "c#" }, 1, new int[] { 2, 3 });

    //var tuple2 = new Tuple<int, int[]>(1, new int[] { 2, 3 });

    //var tuple3 = new Tuple<int, (int X, int Y)[]>(1, new (int X, int Y)[] { (2, 3), (5, 8) });

    ////var tuple4 = new int[(int X, int Y)[]] > (1, new(int X, int Y)[] { (2, 3), (5, 8) });

    //var tuple5 = new Tuple<int, (int X, int Y)[]>(1, new (int X, int Y)[] { (2, 3), (5, 8) });


    //var listCountryPopulation = new List<Tuple<int, string, string>>();
    //listCountryPopulation.Add(new Tuple<int, string, string>(2, "USA", "328 Millionen"));


    //        var foo = Enumerable.Range(1, 10).Select(z => (Alpha: 43, Beta: "world")).ToArray();


    //private static ((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[] ICoordinates = new[] {
    //        ( (-1,0),(0,0),(1,0),(2,0) ),
    //        ( (0,-1),(0,0),(0,1),(0,2) ),
    //        ( (1,0),(0,0),(-1,0),(-2,0) ),
    //        ( (0,1),(0,0),(0,-1),(0,-2) )
    //        };
    //private static ((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[] OCoordinates = new[] {
    //        ( (0,-1),(0,0),(1,0),(1,-1) ),
    //        ( (0,-1),(0,0),(1,0),(1,-1) ),
    //        ( (0,-1),(0,0),(1,0),(1,-1) ),
    //        ( (0,-1),(0,0),(1,0),(1,-1) )
    //        };
    //private static ((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[] ZCoordinates = new[] {
    //        ( (-1,0),(0,0),(1,0),(2,0) ),
    //        ( (0,-1),(0,0),(0,1),(0,2) ),
    //        ( (1,0),(0,0),(-1,0),(-2,0) ),
    //        ( (0,1),(0,0),(0,-1),(0,-2) )
    //        };
    //private static ((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[] SCoordinates = new[] {
    //        ( (-1,0),(0,0),(0,-1),(1,-1) ),
    //        ( (0,-1),(0,0),(1,0),(1,1) ),
    //        ( (1,0),(0,0),(0,1),(1,1) ),
    //        ( (0,1),(0,0),(-1,0),(-1,-1) )
    //        };
    //private static ((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[] TCoordinates = new[] {
    //        ( (-1,0),(0,0),(1,0),(0,-1) ),
    //        ( (0,-1),(0,0),(0,1),(1,0) ),
    //        ( (1,0),(0,0),(-1,0),(0,1) ),
    //        ( (0,1),(0,0),(0,-1),(-1,0) )
    //        };
    //private static ((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[] LCoordinates = new[] {
    //        ( (-1,0),(0,0),(1,0),(1,-1) ),
    //        ( (1,-1),(0,0),(-1,1),(1,2) ),
    //        ( (1,1),(0,0),(-1,-1),(-2,0) ),
    //        ( (-1,1),(0,0),(1,-1),(0,-2) )
    //        };
    //private static ((int X, int Y), (int X, int Y), (int X, int Y), (int X, int Y))[] JCoordinates = new[] {
    //        ( (1,0),(0,0),(-1,0),(-1,-1) ),
    //        ( (0,1),(0,0),(0,-1),(1,-1) ),
    //        ( (-1,0),(0,0),(1,0),(1,1) ),
    //        ( (0,-1),(0,0),(0,1),(-1,1) )
    //        };


}
