using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Managers
{
    internal static class MessagesManager
    {
        private static int level;
        private static int figure;
        private static int points;
        internal static (int x, int y) LevelMsgCoordinates = (23, 8);
        internal static (int x, int y) FigureMsgCoordinates = (23, 10);
        internal static (int x, int y) PointsMsgCoordinates = (23, 12);
        internal static (int x, int y) PreviewMsgCoordinates = (23, 1);
        internal static (int x, int y) WelcomeMsgCoordinates = (4, 10);

        internal static void PrepareMessages()
        {
            level = 1;
            figure = 1;
            points = 0;
            PrintInfoMessages();
        }



        internal static void AddPoints(int point)
        {
            points += point;
        }

        internal static void AddLevel()
        {
            level++;
        }

        internal static void AddFigure()
        {
            figure++;
        }

        internal static void PrintInfoMessages()
        {
            Console.ResetColor();
            Console.SetCursorPosition(PreviewMsgCoordinates.x, PreviewMsgCoordinates.y);
            Console.WriteLine($"Next Figure:");
            Console.SetCursorPosition(LevelMsgCoordinates.x, LevelMsgCoordinates.y);
            Console.WriteLine($"Level - {level}/8");
            Console.SetCursorPosition(FigureMsgCoordinates.x, FigureMsgCoordinates.y);
            Console.WriteLine($"Figure - {figure}/56");
            Console.SetCursorPosition(PointsMsgCoordinates.x, PointsMsgCoordinates.y);
            Console.WriteLine($"Points - {points}");
        }

        internal static void PrintWelcomeMessage()
        {
            Console.Clear();
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y);
            Console.WriteLine($"Press any key to start.");
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y + 1);
            Console.WriteLine($"Or 'Q' to quit..");
        }

        internal static void PrintContinueMessage()
        {
            Console.Clear();
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y);
            Console.WriteLine($"Press any key to continue.");
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y + 1);
            Console.WriteLine($"Or 'Q' to quit..");
        }

        internal static void PrintScoresMessage()
        {
            Console.Clear();
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y);
            Console.WriteLine($"You'r scores: {points}");
        }

    }
}
