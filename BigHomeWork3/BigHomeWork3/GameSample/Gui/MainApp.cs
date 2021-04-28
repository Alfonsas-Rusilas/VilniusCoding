using BigHomeWork3.GameSample.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Gui
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // Papildoma užduotis 2021-04-21 - moovinti priešus (kurie nori iššūkio)
            // 
            //Console.WriteLine("Labas");
            //GameController gameController = new GameController();
            //gameController.StartGame();

            // override - funkcijų perrašymas paveldėtoje klasėje,
            // virtual - reiškia kita child klasė gali ją perrašyti;
            // 
            // yra leidžiama perdengti funkcijas - hiding (bet nepraktikuojama)
            //
            // abstract - netiksli ir abstarkti klasė, tai pav. GuiObject
            // galima ir metoduose: public virtual void Fly()
            // sealed - paskutinis abstrakcijos lygis, nebegalima išplėsti
            //
            // Properties:
            // 

            //Frame frame = new Frame(0, 0, Console.WindowWidth-1, Console.WindowHeight-1, '%');
            //frame.Render();

            /*
            Window window = new Window(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1, '%');
            window.Render();
            */

            List<TextLine> list = new List<TextLine>();
            list.Add(new TextLine(10, 4, 15, "Super duper žaidimas!", true));
            list.Add(new TextLine(10, 5, 15, "Vardas Pavardaitis kūryba", true));
            list.Add(new TextLine(10, 6, 15, "Made in Vilnius Coding Shool", true));
            TextBlock textBlock = new TextBlock(0, 0, 0, list);
            textBlock.Render();

            list.Clear();
            list.Add(new TextLine(3, Console.WindowHeight-2, 1, "WindowWidth: "+Console.WindowWidth));
            list.Add(new TextLine(3, Console.WindowHeight-3, 1, "WindowHeight: "+Console.WindowHeight));
            TextBlock info = new TextBlock(0, 0, 0, list);
            info.Render();

            //TextLine line = new TextLine(3, Console.WindowHeight - 4, 1, "WindowWidth=" + Console.WindowWidth);
            //line.Render();

            int a = Console.WindowWidth / 4;
            int buttonPlotis = 20;
            int buttonAukstis = 5;

            Button startButton = new Button(a- buttonPlotis / 2, Console.WindowHeight / 2, buttonPlotis, buttonAukstis, "Start");
            startButton.IsActive = true;
            startButton.Render();

            Button creditButton = new Button((2*a)- buttonPlotis / 2, Console.WindowHeight / 2, buttonPlotis, buttonAukstis, "Credit");
            creditButton.Render();

            Button quitButton = new Button((3*a)- buttonPlotis / 2, Console.WindowHeight / 2, buttonPlotis, buttonAukstis, "Quit");
            quitButton.Render();


            Console.ReadKey();
        }
    }
}
