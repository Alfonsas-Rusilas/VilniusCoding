using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Windows
{
    class MenuWindow : Window
    {
        private TextBlock titleTextBlock;
        private Button startButton;
        private Button creditButton;
        private Button quitButton;

        public MenuWindow(int x,int y,int width,int height) : base(x,y,width,height)
        {
            List<TextLine> list = new List<TextLine>();
            list.Add(new TextLine(10, 4, 15, "Super duper žaidimas!", true));
            list.Add(new TextLine(10, 5, 15, "Vardas Pavardaitis kūryba", true));
            list.Add(new TextLine(10, 6, 15, "Made in Vilnius Coding Shool", true));
            titleTextBlock = new TextBlock(0, 0, 0, list);

            int a = Console.WindowWidth / 4;
            int buttonPlotis = 20;
            int buttonAukstis = 5;
            startButton = new Button(a - buttonPlotis / 2, Console.WindowHeight / 2, buttonPlotis, buttonAukstis, "Start");
            startButton.IsActive = true;
            creditButton = new Button((2 * a) - buttonPlotis / 2, Console.WindowHeight / 2, buttonPlotis, buttonAukstis, "Credit");
            quitButton = new Button((3 * a) - buttonPlotis / 2, Console.WindowHeight / 2, buttonPlotis, buttonAukstis, "Quit");
        }

        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();
            startButton.Render();
            creditButton.Render();
            quitButton.Render();
            Console.SetCursorPosition(0, 0);
        }


    }
}
