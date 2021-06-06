using BigHomeWork5.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Managers
{
    internal static class MessagesManager
    {
        internal static (int x, int y) LevelMsgCoordinates = (23, 8);
        internal static (int x, int y) FigureMsgCoordinates = (23, 10);
        internal static (int x, int y) PointsMsgCoordinates = (23, 12);
        internal static (int x, int y) PreviewMsgCoordinates = (23, 1);
        internal static (int x, int y) WelcomeMsgCoordinates = (4, 10);


        internal static void PrintInfoMessages()
        {
            Console.ResetColor();
            Console.SetCursorPosition(PreviewMsgCoordinates.x, PreviewMsgCoordinates.y);
            Console.WriteLine($"Next Figure:");
            Console.SetCursorPosition(LevelMsgCoordinates.x, LevelMsgCoordinates.y);
            Console.WriteLine($"Level - {GameData.level}/8");
            Console.SetCursorPosition(FigureMsgCoordinates.x, FigureMsgCoordinates.y);
            Console.WriteLine($"Figure - {GameData.figureCount}/56 ");
            Console.SetCursorPosition(PointsMsgCoordinates.x, PointsMsgCoordinates.y);
            Console.WriteLine($"Points - {GameData.points}  ");
        }

        internal static void PrintWinnerMessage()
        {
            Console.Clear();
            Console.ResetColor();
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y);
            Console.WriteLine($"You are winner!!!");
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y+1);
            Console.WriteLine($"Score: {GameData.points}");
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y+2);
            Console.WriteLine($"Press 'Q' to quit..");
        }

        internal static void PrintGameOverMessage()
        {
            Console.Clear();
            Console.ResetColor();
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y);
            Console.WriteLine($"GAME OVER");
            Console.SetCursorPosition(WelcomeMsgCoordinates.x, WelcomeMsgCoordinates.y + 1);
            Console.WriteLine($"Score: {GameData.points}");
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
            Console.WriteLine($"You'r scores: {GameData.points}");
        }

    }
}
