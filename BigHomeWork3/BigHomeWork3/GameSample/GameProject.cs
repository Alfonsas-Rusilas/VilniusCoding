using BigHomeWork3.GameSample.Game;
using BigHomeWork3.GameSample.Windows;
using System;

namespace BigHomeWork3
{
    class GameProject
    {
        static void Main(string[] args)
        {
            GuiController guiController = new GuiController();
            guiController.ShowMenu();

            bool running = true;
            do
            {
                var ch = Console.ReadKey(false).Key;
                switch (ch)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.LeftArrow:
                        guiController.FocusBackButton();
                        break;
                    case ConsoleKey.RightArrow:
                        guiController.FocusNextButton();
                        break;
                    case ConsoleKey.Enter:
                        if (guiController.GetActiveButtonLabel() == "Quit") return;
                        if (guiController.GetActiveButtonLabel() == "Credit") guiController.ShowCreditMenu();
                        guiController.StartGame();
                        //guiController.OnPressButton();
                        //guiController.ShowCreditMenu();
                        break;
                }
            } while (running);

            Console.ReadKey();
        }


    }
}
