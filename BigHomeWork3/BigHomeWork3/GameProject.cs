using BigHomeWork3.GameSample.Game;
using BigHomeWork3.GameSample.Windows;
using System;

namespace BigHomeWork3
{
    class GameProject
    {
        static void Main(string[] args)
        {
            //Console.CursorVisible = false;

            GuiController guiController = new GuiController();
            guiController.ShowMenu();



            //MenuWindow menuWindow = new MenuWindow(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1);
            //menuWindow.Render();

            ////CreditWindow creditWindow = new CreditWindow(10, 10, 14, 14);
            ////creditWindow.Render();

            Console.ReadKey();
        }
    }
}
