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
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.LeftArrow:
                        guiController.FocusBackButton();
                        break;
                    case ConsoleKey.RightArrow:
                        guiController.FocusNextButton();
                        break;
                    case ConsoleKey.Enter:
                        if (guiController.GetActiveButtonLabel() == "Quit")
                        {
                            return;
                        }
                        if (guiController.GetActiveButtonLabel() == "Credit")
                        {
                            guiController.ShowCreditMenu();
                        }
                        if (guiController.GetActiveButtonLabel() == "Start")
                        {
                            guiController.StartGame();
                        }
                        guiController.ShowMenu();
                        break;
                }
            } while (pressedChar.Key != ConsoleKey.Escape);
        }


    }
}
