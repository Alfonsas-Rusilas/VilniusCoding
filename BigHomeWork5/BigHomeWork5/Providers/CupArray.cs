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

        private static int[,] Array2D = new int[,]
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},            //(x=0,y=0)(0,1)(0,2)(0,3)(0,4)..(0,16)
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},    //x=3; y=[0..16]
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},    // Matrica.Length(0) = 25; Matrica.Length(1)=17
            {4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4},
            {5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,5},
            {6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,6},
            {7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
            {8,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8},
            {9,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {8,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {9,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {4,1,2,3,4,5,6,7,8,9,1,1,2,3,4,5,6},
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

        internal static int RotateRightArray2DValue(int x, int y)
        {
            throw new NotImplementedException();
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
            if (y>24 || x>16)
            {
                return -1;
            } else
            {
                return Array2D[b, x];
            }               
            
        }

        internal static string GetArray2DElement(int x, int y)
        {
            return $"Matrica[{x},{y}]={Array2D[y, x]}; {GetArray2DRow(x)}";
        }

        internal static string GetArray2DRow(int row)
        {
            int rowNumber = row;
            int[] ar = Enumerable.Range(0, Array2D.GetLength(1)).Select(x => Array2D[rowNumber, x]).ToArray();
            string str = $"ROW={rowNumber}: " + string.Join("", ar);
            return str;
        }

        internal static void UpdateDownSide(int x, int y)
        {
            Array2D[y, x] = 1;
        }

        internal static void UpdateLeftSide(int x, int y)
        {
            Array2D[y, x] = 1;
        }

        internal static void UpdateRightSide(int x, int y)
        {
            Array2D[y, x] = 1;
        }

        internal static List<string> GetAllArray2D()
        {
            //int rowNumber = 2;
            //int[] ar = Enumerable.Range(0, Array2D.GetLength(1)).Select(x => Array2D[rowNumber, x]).ToArray();
            //string str = string.Join("", ar);
            Console.ResetColor();
            string strRow = "";
            List<string> strTmp = new List<string>();
            int rowLength = Array2D.GetLength(0);
            int colLength = Array2D.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    strRow += $"{Array2D[i, j]}";
                }
                strTmp.Add(strRow);
                strRow = "";
            }
            return strTmp;
        }

        internal static void DrawArray2D()
        {
            List<string> strL = GetAllArray2D();

            int x = AppParam.GameCupWidth + AppParam.InfoPanelWidth;
            int y = 0;

            Console.SetCursorPosition(x, y);
            foreach (var strl in strL)
            {
                Console.Write(strl);
                y++;
                Console.SetCursorPosition(x, y);
            }
        }

        internal static void DrawArray2D(int a, int b)
        {
            List<string> strL = GetAllArray2D();

            int x = a; // AppParam.GameCupWidth + AppParam.InfoPanelWidth;
            int y = b; //; ;

            Console.SetCursorPosition(x, y);
            foreach (var strl in strL)
            {
                Console.Write(strl);
                y++;
                Console.SetCursorPosition(x, y);
            }
        }



    }

    public class CustomArray<T>
    {
        public T[] GetColumn(T[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public T[] GetRow(T[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }
    }



}
