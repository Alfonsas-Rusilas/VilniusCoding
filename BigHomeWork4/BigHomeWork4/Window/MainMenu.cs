using BigHomeWork4.Game;
using BigHomeWork4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Window
{
    class MainMenu : Frame
    {
        private List<Button> buttonList = new List<Button>();
        
        public MainMenu(int x, int y, int width, int height) : base (x, y, width, height)
        {
            int btnWidth = App.ScreenWidth / 6;
            int btnHeight = App.ScreenHeight / 7;
            int tarpasX = (App.ScreenWidth - 2 * btnWidth) / 3;
            buttonList.Add(new Button(ButtonType.TypePlay, tarpasX, App.ScreenHeight/2, btnWidth, btnHeight, "P - Play"));
            buttonList.Add(new Button(ButtonType.TypeQuit, tarpasX *2+ btnWidth, App.ScreenHeight / 2, btnWidth, btnHeight, "Q - Quit"));
        }

        public override void Render()
        {
            base.Render();
            buttonList[0].Render();
            buttonList[1].Render();
        }
    }
}
