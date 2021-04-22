using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
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

            TextLine lineStringSuper = new TextLine(10, 4, 15, "Super duper žaidimas");
            lineStringSuper.SetCenter(true);
            lineStringSuper.Render();

            TextLine lineStringVardas = new TextLine(10, 5, 15, "Vardas Pavardaitis kūryba");
            lineStringVardas.SetCenter(true);
            lineStringVardas.Render();

            TextLine lineStringMade = new TextLine(10, 6, 15, "Made in Vilnius Coding Shool");
            lineStringMade.SetCenter(true);
            lineStringMade.Render();

            int a = Console.WindowWidth / 4;
            int plotis = 10;

            Button btn_start = new Button(a-plotis/2, 20, 10, 4, "Start");
            btn_start.SetActive(true);
            btn_start.Render();

            a += a;
            Button btn_credit = new Button(a-plotis/2, 20, 10, 4, "Credit");
            btn_credit.Render();

            a += a;
            Button btn_quit = new Button(a-plotis/2, 20, 10, 4, "Quit");
            btn_quit.Render();



            Console.ReadKey();
        }
    }
}
