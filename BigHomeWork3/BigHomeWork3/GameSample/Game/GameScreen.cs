using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigHomeWork3.GameSample.Game;
using BigHomeWork3.GameSample.Gui;
using BigHomeWork3.GameSample.Unit;
using BigHomeWork3.GameSample.Windows;

namespace BigHomeWork3.GameSample.Game
{
    class GameScreen
    {
        private Hero hero;
        private Frame screenBorder;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int x, int y, int width, int height)
        {
            screenBorder = new Frame(x, y, width, height, '*');
        }

        public void Render()
        {
            screenBorder.Render();
            hero.Render();
        }

        public void RenderFrame()
        {
            screenBorder.Render();
        }


        public int GetHeroWidth()
        {
            //return (hero==null)? 10 : hero.HeroWidth;
            return StaticClass.HeroWidth;
        }

        public int GetHeroHight()
        {
            //return (hero == null) ? 2 : hero.HeroHeight;
            return StaticClass.HeroHeight;
            
        }

        public int ScreenWidth()
        {
            return screenBorder.Width;
        }

        public int ScreenHeight()
        {
            return screenBorder.Height;
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




        //public void Render()
        //{
        //Console.WriteLine("--------------Render()--------------------");
        //hero.PrintInfo();
        //for (int i = 0; i < enemies.Count; i++)
        //{
        //    enemies[i].PrintInfo();
        //}
        //}

    }
}
