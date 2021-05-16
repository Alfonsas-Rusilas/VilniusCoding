using BigHomeWork4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Game
{
    class GameRunner
    {
        private List<Player> Players;
        private TextLine StatusLabel;
        private int PlayersCount;
        private const int MaxPlayersCount = 7;
        private const int MaxDiceForPlayerCount = 5;
        private const int PlayerWidth = 15;
        private const int StartRenderX = 4;
        private const int StartRenderY = 4;

        private int PlayerDiceCount;
        private string Winner = "";


        public GameRunner(int PlayersCount, int PlayerDiceCount)
        {
            Console.Clear();
            this.PlayersCount = (PlayersCount < MaxPlayersCount) ? PlayersCount : MaxPlayersCount;
            this.PlayerDiceCount = (PlayerDiceCount > MaxDiceForPlayerCount) ? MaxDiceForPlayerCount : PlayerDiceCount;
            int xas = StartRenderX;
            Players = new List<Player>();
            for (int i = 0; i < PlayersCount; i++)
            {
                Players.Add(new Player(xas, StartRenderY, PlayerWidth, 1, "Player" + (i + 1), this.PlayerDiceCount));
                xas = xas + PlayerWidth + 1;
            }
            StatusLabel = new TextLine(10, App.ScreenHeight - 1, 40, "Šiuo metu niekas nevykdoma.");
        }

        public string RunGame()
        {
            Render();

            bool needToContinue = true;
            int CurrentPlayerIndex = 0;
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    if (pressedChar.Key == ConsoleKey.Escape)
                    {
                        needToContinue = false;
                    }
                }


                Recalculate(CurrentPlayerIndex);
                CurrentPlayerIndex++;
                //System.Threading.Thread.Sleep(250);
            } while (needToContinue && CurrentPlayerIndex<Players.Count);


            /*
            //int win = Players.Max(max => max.Scores);
            var WinnerPlayer = from p in Players
                               //group p by p.GetPlayerName into playersGroup
                               select new { Names = p.GetPlayerName(), BestScore = p.Scores.    ax(x => x.Score) };
                             //where Players.Max(p.Scores)
                             //select p;
            */
            /*
            var teamBestScores =
    from player in players
    group player by player.Team into playerGroup
    select new
    {
        Team = playerGroup.Key,
        BestScore = playerGroup.Max(x => x.Score),
    };
            */

            //Pla
            return Winner;
        }

        private void Render()
        {
            foreach (var player in Players)
            {
                player.Render();
            }
            StatusLabel.Render();
        }

        private void Recalculate(int CurrentPlayerIndex)
        {
            bool needToContinue = true;
            int CurrentDice = 0;
            do
            {
                //while (Console.KeyAvailable)
                //{
                //    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                //    if (pressedChar.Key == ConsoleKey.Escape)
                //    {
                //        needToContinue = false;
                //    }
                //}

                int score = Players[CurrentPlayerIndex].GetDiceScore(CurrentDice);
              
                Players[CurrentPlayerIndex].UpdateDice(CurrentDice, "Dices-" + score);
                
                Players[CurrentPlayerIndex].UpdateScores(score);

                StatusLabel.Label = "Žaidžia: Player" + (CurrentPlayerIndex+1) + ". Meta kauliuką Nr." + (CurrentDice+1);
                StatusLabel.Render();

                CurrentDice++;

                System.Threading.Thread.Sleep(250);
            } while (needToContinue && CurrentDice< Players[CurrentPlayerIndex].DicesCount);
        }

        

    }
}
