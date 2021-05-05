using BigHomeWork3.GameSample.Game;
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
        private List<Button> buttonList = new List<Button>();

        public MenuWindow(int x,int y,int width,int height) : base(x,y,width,height)
        {
            List<TextLine> list = new List<TextLine>();
            list.Add(new TextLine(10, 4, 15, "Super duper žaidimas!", true));
            list.Add(new TextLine(10, 5, 15, "Vardas Pavardaitis kūryba", true));
            list.Add(new TextLine(10, 6, 15, "Made in Vilnius Coding Shool", true));
            titleTextBlock = new TextBlock(0, 0, 0, list);

            int a = AppSettings.GameScreenWidth / 4;
            int buttonPlotis = 20;
            int buttonAukstis = 5;
            startButton = new Button(a - buttonPlotis / 2, AppSettings.GameScreenHeight / 2, buttonPlotis, buttonAukstis, "Start");
            startButton.IsActive = true;
            creditButton = new Button((2 * a) - buttonPlotis / 2, AppSettings.GameScreenHeight / 2, buttonPlotis, buttonAukstis, "Credit");
            quitButton = new Button((3 * a) - buttonPlotis / 2, AppSettings.GameScreenHeight / 2, buttonPlotis, buttonAukstis, "Quit");
            buttonList.Add(startButton);
            buttonList.Add(creditButton);
            buttonList.Add(quitButton);
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

        public void SetFocusOnNextButton()
        {
            int index = buttonList.FindIndex(a => a.IsActive == true);
            foreach (var item in buttonList)
            {
                item.SetActive(false); 
            }
            if (index + 1 >= buttonList.Count())
            {
                buttonList[0].SetActive(true);
            }
            else
            {
                buttonList[index + 1].SetActive(true);
            }
            RenderButtons();
        }

        public void SetFocusOnBackButton()
        {
            int index = buttonList.FindIndex(a => a.IsActive == true);
            foreach (var item in buttonList)
            {
                item.SetActive(false);
            }
            if (index - 1 < 0)
            {
                buttonList[buttonList.Count - 1].SetActive(true);
            }
            else
            {
                buttonList[index - 1].SetActive(true);
            }
            RenderButtons();
        }

        public void OnPressButton()
        {
            int index = buttonList.FindIndex(a => a.IsActive == true);
        }

        private void RenderButtons()
        {
            foreach (var btn in buttonList)
            {
                btn.Render();
            }
        }

        public string GetActiveButtonLabel()
        {
            int index = buttonList.FindIndex(a => a.IsActive == true);
            return buttonList[index].Label.Label;
        }




    }
}
