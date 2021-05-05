using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Game
{
    static class AppSettings
    {
        public static int HeroWidth { set; get; } = 10;
        public static int HeroHeight { set; get; } = 2;
        public static int GameScreenWidth { set; get; } = Console.WindowWidth;
        public static int GameScreenHeight { set; get; } = Console.WindowHeight;
        public static int GameScreenX { set; get; } = 0;
        public static int GameScreenY { set; get; } = 0;
        public static int EnemyCount { set; get; } = 5;
        public static int EnemyAreaFromX { set; get; } = GameScreenX + 6;
        public static int EnemyAreaFromY { set; get; } = GameScreenY + 5;
        public static int EnemyAreaToX { set; get; } = GameScreenWidth - 6;
        public static int EnemyAreaToY { set; get; } = GameScreenHeight / 3;
        public static int BallMoovingSpeed { set; get; } = 3;
        public static int EnemiesMoovingSpeed { set; get; } = 5;

    }
}
