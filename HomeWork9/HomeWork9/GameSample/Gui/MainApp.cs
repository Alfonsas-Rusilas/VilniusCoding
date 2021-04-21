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
             
            


            //Console.Write("Paspauskite...");
            //Console.ReadLine();

            Frame frame = new Frame(1, 1, 120, 30, 'z');
            frame.Render();

            Frame frame2 = new Frame(10, 10, 25, 5, '%');
            frame2.Render();


            Console.SetCursorPosition(20, 20);
            TextLine lineString = new TextLine(20, 20, 15, "=Label=");
            lineString.Render();


        }
    }
}
