using BigHomeWork4.Game;
using BigHomeWork4.Gui;
using BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigHomeWork4
{
    class MainProgram
    {
        public static int[,] arrow = new int[6, 4] { { 3, 3, 2, 1 }, { 4, 4, 0, 2 }, { 5, 5, 1, 1 }, { 0, 0, 5, 4 }, { 1, 1, 3, 5 }, { 2, 2, 4, 1 } };
        static void Main(string[] args)
        {
            MenuController menuController = new MenuController();
            menuController.ShowMenu();

            //Console.WriteLine($"Pirmas Up: {arrow[0,0]}");    
            //Console.WriteLine($"Šeštas Up: {arrow[5,0]}");    


        }

    }
}

