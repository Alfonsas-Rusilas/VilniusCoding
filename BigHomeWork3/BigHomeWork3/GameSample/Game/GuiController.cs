using BigHomeWork3.GameSample.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Game
{
    class GuiController
    {
        private MenuWindow menuWindow;
        private CreditWindow creditWindow;
        private GameController gameController;

        public GuiController()
        {
            Console.CursorVisible = false;
            menuWindow = new MenuWindow(AppSettings.GameScreenX, AppSettings.GameScreenY, AppSettings.GameScreenWidth - 1, AppSettings.GameScreenHeight - 1);
        }

        public void ShowMenu()
        {
            menuWindow.Render();
        }

        public void FocusNextButton()
        {
            menuWindow.SetFocusOnNextButton();
        }

        public void FocusBackButton()
        {
            menuWindow.SetFocusOnBackButton();
        }

        public string GetActiveButtonLabel()
        {
            return menuWindow.GetActiveButtonLabel();
        }


        public void ShowCreditMenu()
        {
            creditWindow = new CreditWindow(10, 10, 14, 14);
            creditWindow.Render();
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
            } while (pressedChar.Key != ConsoleKey.Enter);
            menuWindow.Render();
        }

        public void StartGame()
        {
            gameController = new GameController(AppSettings.GameScreenX, AppSettings.GameScreenY, AppSettings.GameScreenWidth - 1, AppSettings.GameScreenHeight - 1);
            gameController.StartGame();
        }

    }
}
