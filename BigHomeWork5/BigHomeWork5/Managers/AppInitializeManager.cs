using BigHomeWork5.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Managers
{
    internal static class AppInitializeManager
    {
        internal static void SetUpWindow()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.BufferWidth = Console.WindowWidth = AppParam.WindowWidth;
            Console.BufferHeight = Console.WindowHeight = AppParam.WindowHeight;
        }
    }
}
