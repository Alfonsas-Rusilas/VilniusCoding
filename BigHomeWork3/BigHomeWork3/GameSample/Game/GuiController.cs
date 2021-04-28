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

        public GuiController()
        {
            Console.CursorVisible = false;
            menuWindow = new MenuWindow(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1);
            creditWindow = new CreditWindow(10, 10, 14, 14);
        }

        public void ShowMenu()
        {
            menuWindow.Render();
        }
    }
}
