using BigHomeWork3.GameSample.Game;
using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Windows
{
    class GameOverWindow : Window
    {
        private Button backButton;
        private TextBlock creditTextBlock;
        public GameOverWindow(int x, int y, int w, int h, string scores, string reason) : base(x, y, w, h)
        {
            int b = 10;
            List<TextLine> list = new List<TextLine>();
            list.Add(new TextLine(10, b, 15, "GAME OVER", true));
            list.Add(new TextLine(10, b + 1, 15, "Scores: " + scores, true));
            list.Add(new TextLine(10, b + 3, 15, "Reason: " + reason, true));
            creditTextBlock = new TextBlock(0, 0, 0, list);
            backButton = new Button(AppSettings.GameScreenWidth / 2 - 10, b + 12, 20, 2, "Back");
            backButton.SetActive(true);
        }

        public override void Render()
        {
            base.Render();
            backButton.Render();
            creditTextBlock.Render();
        }
    }
}
