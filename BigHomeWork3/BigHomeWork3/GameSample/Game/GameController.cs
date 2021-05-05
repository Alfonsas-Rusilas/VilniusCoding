using BigHomeWork3.GameSample.Gui;
using BigHomeWork3.GameSample.Unit;
using BigHomeWork3.GameSample.Windows;
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
            myGame.SetHero(new Hero("HERO", (AppSettings.GameScreenWidth - AppSettings.HeroWidth)/2, AppSettings.GameScreenHeight-4));
            int universalID = 0;
            for (int x = 0; x < AppSettings.EnemyCount; x++)
            {
                Random rnd = new Random();
                myGame.AddEnemy(new Enemy(universalID, "Enemy_" + universalID,  
                    rnd.Next(AppSettings.EnemyAreaFromX, AppSettings.EnemyAreaToX), rnd.Next(AppSettings.EnemyAreaFromY, AppSettings.EnemyAreaToY)));
                universalID++;
            }
            myGame.Render();
            
            bool needToRender = true;
            do
            {
               while (Console.KeyAvailable)
               {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.Spacebar:
                            myGame.CreateBall();
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            break;
                    }
               }
               myGame.Recalculate();
               System.Threading.Thread.Sleep(50);
            } while (!myGame.IsGameLost && needToRender && !myGame.IsGameWin);

            if (needToRender == true) // t.y. išėjome su Escape
            {
                GameOverWindow gameOverWindow = new GameOverWindow(35, 8, 50, 19, myGame.GetScores(), myGame.GetReason()); ;
                gameOverWindow.Render();
            }
            
        }
    }
}
