using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Managers
{
    internal static class EndOfGameManager
    {

        internal static void EndOfGame()
        {
            Console.Clear();
            Console.ResetColor();
            Console.CursorVisible = true;

            MessagesManager.PrintScoresMessage();
            Environment.Exit(0);
        }
        
    }
}
