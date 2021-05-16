using BigHomeWork4.Game;
using BigHomeWork4.Gui;
using BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigHomeWork4
{
    class MainProgram
    {

        static void Main(string[] args)
        {
            MenuController menuController = new MenuController();
            menuController.ShowMenu();

            //int xas = 4;
            //int yas = 4;
            //int PlayerWidth = 15;
            //int DiceCount = 7;

            //List<Player> players = new List<Player>();
            //for (int i = 0; i < 7; i++)
            //{
                
            //    players.Add(new Player(xas, yas, PlayerWidth, 1, "Player" + (i+1), DiceCount));
            //    players[i].Render();
            //    xas = xas + PlayerWidth + 1;
            //}

            //Player player = new Player(4, 4, 15, 1, "Player1", 7);
            //player.Render();

            Console.ReadKey();

            //BoxFrame fb = new BoxFrame(BoxType.None, 20, 15, 15, BoxFrame.BoxHeight, "Scores:" );
            //fb.Render();

            //Button btn = new Button(ButtonType.TypeNone, 20, 15, 15, 5, "Scores\n5");
            //
            //
            //btn.Render();

            //ScoresFrame btn = new ScoresFrame(20, 15, 20, 10, "Player1\nScores:55\nGO");
            //btn.Render();

            //Console.ReadKey();
            //btn.IsActive = true;
            //btn.Render();

            /*
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();
            Console.WriteLine("White on blue.");
            Console.WriteLine("Another line.");
            Console.ResetColor();
            */

        }

    }
}

