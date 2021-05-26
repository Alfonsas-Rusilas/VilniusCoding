using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BigHomeWork5.Providers
{
    internal struct GameData
    {
        internal const int LevelsCount = 8;
        internal const int FiguresPerLevel = 56;

        internal const int PointPerLine = 28;
        internal const int PointsPerLevel = 7;

        internal const int StartSpeed = 450;
        internal const string LogFile = "Logs.ini";

        internal static int speed;
        internal static int points;
        internal static int level;
        internal static int figureCount;

        //internal static Timer speedDelay;

        internal static void ResetData()
        {
            level = 1;
            points = 0;
            figureCount = 1;
            speed = StartSpeed;
        }
    }
}
