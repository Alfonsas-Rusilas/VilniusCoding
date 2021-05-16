using BigHomeWork4.Game;
using BigHomeWork4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BigHomeWork4.Window
{
    class GameOverMenu : Frame
    {
        private List<Button> buttonList = new List<Button>();
        private TextLine InfoLine1; 
        private TextLine InfoLine2;


        public GameOverMenu(int x, int y, int width, int height, string winner) : base(x, y, width, height)
        {
            int btnWidth = App.ScreenWidth / 6;
            int btnHeight = App.ScreenHeight / 7;
            int tarpasX = (App.ScreenWidth - 3 * btnWidth) / 2;
            buttonList.Add(new Button(ButtonType.TypeReplay, tarpasX, App.ScreenHeight / 2, btnWidth, btnHeight, "R - Replay"));
            int xas = tarpasX + btnWidth + 2;
            buttonList.Add(new Button(ButtonType.TypeReplay, xas, App.ScreenHeight / 2, btnWidth, btnHeight, "M - Go to menu"));
            xas = xas + btnWidth + 2;
            buttonList.Add(new Button(ButtonType.TypeQuit, xas, App.ScreenHeight / 2, btnWidth, btnHeight, "Q - Quit"));
            InfoLine1 = new TextLine(x, y+3, width, "Game Over!", true);
            InfoLine2 = new TextLine(x, y + 5, width, "The winner is: " + winner, true);
            Render();
        }

        public override void Render()
        {
            base.Render();
            InfoLine1.Render();
            InfoLine2.Render();
            foreach (var btnitem in buttonList)
            {
                btnitem.Render();
            }
        }

        public MenuReturnType SelectedMenu()
        {
            MenuReturnType SelectedMenu = MenuReturnType.None;
            bool needToContinue = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Q:
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.M:
                            SelectedMenu = MenuReturnType.GoToMenu;
                            needToContinue = false;
                            break;
                        case ConsoleKey.R:
                            SelectedMenu = MenuReturnType.ReplayGame;
                            needToContinue = false;
                            break;
                    }
                }
            } while (needToContinue);
            return SelectedMenu;
        }

    }
}
