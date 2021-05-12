using BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Game
{
    class MenuController
    {
        MainMenu mainMenu;

        public MenuController()
        {
            mainMenu = new MainMenu(0, 0, 119, 29);
        }

        public void ShowMenu()
        {
            mainMenu.Render();
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                //switch (pressedChar.Key)
                //{
                //    case ConsoleKey.P:
                //        gameController.FocusNextButton();
                //        break;
                //    case ConsoleKey.Enter:
                //        if (guiController.GetActiveButtonLabel() == "Quit")
                //        {
                //            return;
                //        }
                //        if (guiController.GetActiveButtonLabel() == "Credit")
                //        {
                //            guiController.ShowCreditMenu();
                //        }
                //        if (guiController.GetActiveButtonLabel() == "Start")
                //        {
                //            guiController.StartGame();
                //        }
                //        guiController.ShowMenu();
                //        break;
                //}
            } while (pressedChar.Key != ConsoleKey.Q);
            mainMenu.ClearFrameRender();
        }
    }
}
