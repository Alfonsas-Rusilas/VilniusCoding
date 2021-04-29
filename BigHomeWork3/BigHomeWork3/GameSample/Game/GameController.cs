using BigHomeWork3.GameSample.Gui;
using BigHomeWork3.GameSample.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Game
{
    class GameController : GuiObject
    {
        

        public GameController(int width, int height) : base(0,0,width,height)
        {
            //
        }

        public void StartGame()
        {
            GameScreen myGame = new GameScreen(Width, Height);
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
