using BigHomeWork5.Enums;
using BigHomeWork5.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Providers
{
    internal static class CupArray
    {
        private static int ArrayRowsCount = 25;
        private static int ArrayRowLenght = 17;


        private static int[,] Array2D = new int[,]
        {
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},            //(x=0,y=0)(0,1)(0,2)(0,3)(0,4)..(0,16)
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},    //x=3; y=[0..16]
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},    // Matrica.Length(0) = 25; Matrica.Length(1)=17
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
            {3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3},
        };

        internal static int RightArray2DValue(int x, int y)
        {
            int a = x + 1;
            if (y > 24 || x > 16)
            {
                return -1;
            }
            else
            {
                return Array2D[y, a];
            }
        }

        internal static int LeftArray2DValue(int x, int y)
        {
            int a = x - 1;
            if (y > 24 || x > 16)
            {
                return -1;
            }
            else
            {
                return Array2D[y, a];
            }
        }

        internal static int DownArray2DValue(int x, int y)
        {
            int b = y + 1;
            if (y > 24 || x > 16)
            {
                return -1;
            } else
            {
                return Array2D[b, x];
            }
        }

        internal static int Array2DValue(int x, int y)
        {
            if (y > 24 || x > 16)
            {
                return -1;
            }
            else
            {
                return Array2D[y, x];
            }
        }

        internal static int RotateRightArray2DValue(int x, int y, FiguresTypes figureType)
        {
            int a = x + 1;

            if (y > 24 || x > 16)
            {
                return -1;
            }
            else
            {
                return Array2D[y, a];
            }
        }


        internal static void UpdateDownSide(int x, int y)
        {
            Array2D[y, x] = 1;
        }


        internal static void MergeElementWithBottom(int x, int y, int colorValue)
        {
            Array2D[y, x] = colorValue;
        }


        internal static int ClearFilledLines()
        {
            int linescount = 0;
            bool IsFilledLines = false;
            do
            {
                for (int row = 0; row < ArrayRowsCount - 1; row++)
                {
                    IsFilledLines = false;
                    if (IsRowFilled(row))
                    {
                        RemoveArrayLine(row);
                        IsFilledLines = true;
                        linescount++;
                        continue;
                    }
                }
            } while (IsFilledLines);
            return linescount * ArrayRowLenght;
        }

        private static void RemoveArrayLine(int row)
        {
            for (int i = row; i > 0; i--)
            {
                SetArrayRow(GetArrayRow(i - 1), i);
            }
            SetArrayRow(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, 0);
            Render();
        }

        internal static void Render()
        {
            int sk;
            int rowLength = Array2D.GetLength(0);
            int colLength = Array2D.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    sk = Array2D[i, j];
                    Console.SetCursorPosition(j, i);
                    Console.BackgroundColor = (ConsoleColor)sk;
                    Console.Write(" ");
                }
            }
        }

        internal static bool IsRowFilled(int row)
        {
            foreach (var item in GetArrayRow(row))
            {
                if (item == 0) return false;
            }
            return true;
        }

        internal static int[] GetArrayColumn(int colum)
        {
            int colLength = Array2D.GetLength(0);
            int[] reta = new int[colLength];

            for (int i = 0; i < colLength; i++)
                {
                    reta[i] = Array2D[i, colum];
                }
            return reta;
        }

        internal static int[] GetArrayRow(int row)
        {
            int rowLength = Array2D.GetLength(1);
            int[] reta = new int[rowLength];
            for (int i = 0; i < rowLength; i++)
            {
                reta[i] = Array2D[row, i];
            }
            return reta;
        }

        internal static void SetArrayRow(int[] arow, int row)
        {
            int rowLength = Array2D.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                Array2D[row, i] = arow[i];
            }
        }


    }
















    //public class CustomArray<T>
    //{
    //    public T[] GetColumn(T[,] matrix, int columnNumber)
    //    {
    //        return Enumerable.Range(0, matrix.GetLength(0))
    //                .Select(x => matrix[x, columnNumber])
    //                .ToArray();
    //    }

    //    public T[] GetRow(T[,] matrix, int rowNumber)
    //    {
    //        return Enumerable.Range(0, matrix.GetLength(1)).Select(x => matrix[rowNumber, x]).ToArray();
    //                
    //                
    //    }
    //}



}
