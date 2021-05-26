using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Providers
{
    internal static class CupWalls
    {
        private static int[] DownSide = new int[] { 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15 };
        private static int[] LeftSide = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        private static int[] RightSide = new int[] { 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17 };

        //public CupWalls()
        //{
        //    DownSide = new int[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
        //    LeftSide = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        //    RightSide = new int[] { 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17 };
        //}

        internal static void UpdateDownSide(int x, int y)
        {
            DownSide[x] = --y;
        }

        internal static int DownSideValue(int x)
        {
            return DownSide[x];
        }

        internal static void UpdateLeftSide(int x, int y)
        {
            LeftSide[y] = ++x;
        }

        internal static int LeftSideValue(int y)
        {
            return LeftSide[y];
        }


        internal static void UpdateRightSide(int x, int y)
        {
            RightSide[y] = --x;
        }

        internal static int RightSideValue(int y)
        {
            return RightSide[y];
        }


        internal static string GetLeftSideString()
        {
            return String.Join(" ", LeftSide);
        }

        internal static string GetRightSideString()
        {
            return String.Join(" ", RightSide);
        }


        internal static string GetDownSideString()
        {
            //return DownSide.Join();
            return String.Join(" ", DownSide);
        }

    }
}
