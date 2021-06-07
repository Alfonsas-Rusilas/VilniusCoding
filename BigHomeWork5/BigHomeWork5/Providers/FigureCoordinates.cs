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
    internal static class FigureCoordinates
    {

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



    }




}
