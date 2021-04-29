using BigHomeWork3.GameSample.Gui;
using BigHomeWork3.GameSample.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Game
{
    class GameController 
    {
        private GameScreen myGame;



        public GameController(int x, int y, int width, int height) 
        {
            myGame = new GameScreen(x, y, width, height);
        }

        public void StartGame()
        {
            myGame.SetHero(new Hero("HERO", (myGame.ScreenWidth() - myGame.GetHeroWidth())/2  , myGame.ScreenHeight()-4));
            //myGame.SetHero(new Hero("HERO", myGame.GetHeroWidth() , myGame.ScreenHeight()-4));

            //Console.WriteLine($"myGame.GetHeroWidth = {myGame.GetHeroWidth()}; sudejus= {myGame.ScreenWidth() / 2 + myGame.GetHeroWidth() / 2}");
            myGame.Render();

            //Console.WriteLine($"myGame.GetHeroWidth = {myGame.GetHeroWidth()}; sudejus= {myGame.ScreenWidth()/2 + myGame.GetHeroWidth()/2}");
            //Console.WriteLine($"myGame.ScreenWidth= {myGame.ScreenWidth()}"); ; 
            //myGame.

            bool leave = false;
            do
            {
                var ch = Console.ReadKey(false).Key;
                if (ch == ConsoleKey.RightArrow)
                {
                    myGame.MoveHeroRight();
                }
                if (ch == ConsoleKey.LeftArrow)
                {
                    myGame.MoveHeroLeft();
                }
                if (ch == ConsoleKey.Escape)
                {
                    leave = true;
                    myGame.MoveHeroLeft();
                }

            } while (!leave);


            /*
            int universalID = 0;
            for (int x = 0; x < 10; x++)
            {
                Random rnd = new Random();
                myGame.AddEnemy(new Enemy(universalID, "Priešas" + universalID, rnd.Next(0, 10), rnd.Next(0, 20)));
                universalID++;
            }
            */
            //myGame.MoveAllEnemysDown();
            //myGame.Render();
            //myGame.MoveHeroLeft();
            //myGame.MoveAllEnemysDown();
            //myGame.GetEnemyByID(2).MoveDown();
            //myGame.Render();

        }
    }
}
