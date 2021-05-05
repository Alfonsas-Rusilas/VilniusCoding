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
        private TextLine ScoreInformation;
        private TextLine ShootsInformation;
        private TextLine LivesInformation;
        private List<Enemy> enemies = new List<Enemy>();
        private List<Ball> balls = new List<Ball>();
        private int shoots = 0;
        private int lives = 3;
        private int score = 0;
        public bool IsGameLost { set; get; } = false;
        public bool IsGameWin { set; get; } = false;

        public GameScreen(int x, int y, int width, int height)
        {
            screenBorder = new Frame(x, y, width, height, '*');
            ScoreInformation = new TextLine((AppSettings.GameScreenWidth/3)*2, AppSettings.GameScreenHeight-1, 1, "| Scores: 0 |");
            ShootsInformation = new TextLine((AppSettings.GameScreenWidth/3), AppSettings.GameScreenHeight - 1, 1, "| Shoots: 0 |");
            LivesInformation = new TextLine(8, AppSettings.GameScreenHeight - 1, 1, "| Lives: 3 |");
        }

        public void Render()
        {
            screenBorder.Render();
            hero.Render();
            foreach (var enemie in enemies)
            {
                enemie.Render();
            }
            ScoreInformation.Render();
            ShootsInformation.Render();
            LivesInformation.Render();
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void MoveHeroRight()
        {
            hero.MoveRight(screenBorder.Width);
        }

        public void MoveHeroLeft()
        {
            hero.MoveLeft(screenBorder.X);
        }

        public void CreateBall()
        {
            Ball ball = new Ball("Ball_", '|', hero.HeroMidX(), hero.HeroY() - 1);
            balls.Add(ball);
            shoots++;
            ShootsInformation.Label = "| Shoots: " + shoots + " |";
            ball.Render();
        }

        public void MoveAllBallsUp()
        {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].MoveUp();
            }
        }

        public void MoveAllEnemysDown()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].MoveDown();
            }
        }

        public void Recalculate()
        {
            MoveAllBallsUp();
            balls.RemoveAll(a => a.Y <= AppSettings.GameScreenY+1 );
            MoveAllEnemysDown();
            ShootsInformation.Render();
            CheckPositionsBallsAndEnemies();
            ScoreInformation.Render();
            CheckEnemysPosition();
        }


        private void CheckEnemysPosition()
        {
            // Nusileido ant herojaus- GameOver
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].X >= hero.X && enemies[i].X <= hero.X + AppSettings.HeroWidth && enemies[i].Y >= hero.Y)
                {
                    IsGameLost = true;
                    return;
                }
            }
            // Nusileido prie pat apačios - minus gyvybė
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].Y >= AppSettings.GameScreenHeight - 2)
                {
                    enemies[i].MarkForDelete = true;
                    enemies[i].ClearRender();
                    lives--;
                    LivesInformation.Label = "| Lives: " + lives + " |";
                    LivesInformation.Render();
                    if (lives <= 0)
                    {
                        IsGameLost = true;
                    }
                }
            }
            enemies.RemoveAll(a => a.MarkForDelete == true);
            // Enemy nebeliko, you are winner!
            if (enemies.Count<=0)
            {
                IsGameWin = true;
            }
        }

        public void CheckPositionsBallsAndEnemies()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                for (int a = 0; a < balls.Count; a++)
                {
                    if (enemies[i].X == balls[a].X && enemies[i].Y == balls[a].Y)
                    {
                        enemies[i].ClearRender();
                        balls[a].ClearRender();
                        score +=100;
                        ScoreInformation.Label = "| Scores: " + score + " |";
                        enemies[i].MarkForDelete = true;
                        balls[a].MarkForDelete = true;
                    }
                }
            }
            enemies.RemoveAll(a => a.MarkForDelete==true);
            balls.RemoveAll(a => a.MarkForDelete==true);
        }

        public string GetScores()
        {
            return score.ToString();
        }

        public string GetReason()
        {
            if (IsGameWin)
            {
                return "You win!!!";
            }
            else 
            if (lives<=0)
            {
                return "All lives was lost.";
            }
            else
            {
                return "Hero is dead.";
            }
        }

    }
}
