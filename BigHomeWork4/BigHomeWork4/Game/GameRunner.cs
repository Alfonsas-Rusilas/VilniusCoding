using BigHomeWork4.Gui;
using BigHomeWork4.Window;
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
        private const int MaxDiceForPlayerCount = 9;
        private const int PlayerWidth = 15;
        private const int StartRenderX = 4;
        private const int StartRenderY = 4;

        private int PlayerDiceCount;
        private string Winner = "";


        public GameRunner(int PlayersCount, int PlayerDiceCount)
        {
            Console.Clear();
            this.PlayersCount = (PlayersCount < MaxPlayersCount) ? PlayersCount : MaxPlayersCount;
            this.PlayerDiceCount = (PlayerDiceCount < MaxDiceForPlayerCount) ? PlayerDiceCount : MaxDiceForPlayerCount;
            int xas = StartRenderX;
            Players = new List<Player>();
            for (int i = 0; i < this.PlayersCount; i++)
            {
                Players.Add(new Player(xas, StartRenderY, PlayerWidth, 1, "Player" + (i + 1), this.PlayerDiceCount));
                xas = xas + PlayerWidth + 1;
            }
            StatusLabel = new TextLine(10, App.ScreenHeight - 1, 40, "Šiuo metu niekas nevykdoma.");
        }

        public MenuReturnType RunGame()
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

            StatusLabel.Label = "Game finished. Press any key to continue...";
            StatusLabel.Render();
            Console.ReadKey();
            Console.Clear();

            int MaxScoresValue = Players.Max(p => p.Scores);
            var Winners = from p in Players
                          where p.Scores == MaxScoresValue
                          select new { Name = p.GetPlayerName(), Score = p.Scores };

            foreach (var item in Winners)
            {
                Winner = Winner + " " + item.Name + " with " + item.Score + " scores;";
            }

            GameOverMenu gameOverMenu = new GameOverMenu(App.ScreenX, App.ScreenY, App.ScreenWidth-1 , App.ScreenY-1, Winner);
            //gameOverMenu.Render();
            MenuReturnType menu = gameOverMenu.SelectedMenu();
            //Console.ReadKey();

            return menu;
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
                int score = Players[CurrentPlayerIndex].GetDiceScore(CurrentDice);
                Players[CurrentPlayerIndex].UpdateDice(CurrentDice, "Dice-" + score);
                Players[CurrentPlayerIndex].UpdateScores(score);
                StatusLabel.Label = "Žaidžia: Player" + (CurrentPlayerIndex+1) + ". Meta kauliuką Nr." + (CurrentDice+1);
                StatusLabel.Render();
                CurrentDice++;
                System.Threading.Thread.Sleep(40);
            } while (needToContinue && CurrentDice< Players[CurrentPlayerIndex].DicesCount);
        }

    }
}
