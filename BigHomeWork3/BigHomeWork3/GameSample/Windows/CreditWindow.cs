using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Windows
{
    class CreditWindow : Window
    {
        private Frame frame;
        private TextBlock creditTextBlock;
        private Button backButton;
        public CreditWindow(int x, int y, int width, int height) : base(x,y,width,height)
        {
            int cw = Console.WindowWidth;
            int ch = Console.WindowHeight;

            frame = new Frame(35, 8, 50, 19, '@');

            int b = 10;
            List<TextLine> list = new List<TextLine>();
            list.Add(new TextLine(10, b, 15, "Game design:", true));
            list.Add(new TextLine(10, b+1, 15, "Vardas Pavardaitis", true));
            list.Add(new TextLine(10, b+3, 15, "Programuotojas:", true));
            list.Add(new TextLine(10, b+4, 15, "Vardas Vardaitis", true));
            list.Add(new TextLine(10, b+6, 15, "\'Art\':", true));
            list.Add(new TextLine(10, b+7, 15, "Vardas Pavardaitis", true));
            list.Add(new TextLine(10, b+9, 15, "Marketingas:", true));
            list.Add(new TextLine(10, b+10, 15, "Vardas Vardaitis", true));
            
            creditTextBlock = new TextBlock(0, 0, 0, list);

            backButton = new Button(cw/2-10, b+12, 20, 2, "Back");
        }

        public override void Render()
        {
            frame.Render();
            backButton.Render();
            creditTextBlock.Render();
        }

    }
}
