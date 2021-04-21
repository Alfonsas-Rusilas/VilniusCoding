using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Game
{
    class GameController
    {
        public void StartGame()
        {
            GameScreen myGame = new GameScreen(40, 40);
            myGame.SetHero(new Hero("Herojus", 20, 20));

            int universalID = 0;
            for (int x = 0; x < 10; x++)
            {
                Random rnd = new Random();
                myGame.AddEnemy(new Enemy(universalID, "Priešas" + universalID, rnd.Next(0, 10), rnd.Next(0, 80)));
                universalID++;
            }

            myGame.MoveAllEnemysDown();
            myGame.Render();
            myGame.MoveHeroLeft();
            myGame.MoveAllEnemysDown();
            myGame.GetEnemyByID(2).MoveDown();
            myGame.Render();
        }
    }
}
