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
            mainMenu = new MainMenu(App.ScreenX, App.ScreenY, App.ScreenWidth-1, App.ScreenHeight-1);
        }

        public void ShowMenu()
        {
            mainMenu.Render();
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.P:
                        Console.Clear();
                        GameController gameController = new GameController();
                        gameController.StartGame();
                        mainMenu.Render();
                        break;
                    default:
                        break;
                }
            } while (pressedChar.Key != ConsoleKey.Q);
            mainMenu.ClearFrameRender();
        }
    }
}
