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
                        Console.WriteLine("Key: Escape");
                        running = false;
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Key: LeftArrow");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Key: RightArrow");
                        guiController.FocusNextButton();
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("Key: Enter");
                        break;
                }
            } while (running);

            Console.ReadKey();
        }

        //public void FocusOnNextButton()
        //{

        //}

    }
}
