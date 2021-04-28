using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigHomeWork3.GameSample.Game;
using BigHomeWork3.GameSample.Unit;

namespace BigHomeWork3.GameSample.Game
{
    class GameScreen
    {
        private int width;
        private int height;
        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void MoveAllEnemysDown()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].MoveDown();
            }
            
        }

        public Enemy GetEnemyByID(int id)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].GetId() == id)
                {
                    return enemies[i];
                }
            }
            return null;
        }

        public void MoveHeroRight()
        {
            hero.MoveRight();
        }

        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }


        public void Render()
        {
            Console.WriteLine("--------------Render()--------------------");
            hero.PrintInfo();
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].PrintInfo();
            }
        }

    }
}
