using BigHomeWork4.GameStatus;
using BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Game
{
    class GameController
    {
        private GameStatus gameStatus;
        private PlayerSelectionController playerSelectionController;
        private DiceSelectionController diceSelectionController;
 
        public GameController()
        {
            gameStatus = new GameStatus();
        }

        public void StartGame()
        {
            // TO DO : Players Select Count
            playerSelectionController = new PlayerSelectionController();
            gameStatus.PlayersCount = playerSelectionController.GetPlayersCount();
            //Console.WriteLine($"Pasirinkta {gameStatus.PlayersCount}");

            // TO DO :  DiecesSelect
            diceSelectionController = new DiceSelectionController();
            gameStatus.DicesCount = diceSelectionController.GetDiceCount();
            //Console.WriteLine($"Pasirinkta {gameStatus.DicesCount}");

            // TO DO :  Run..
            GameRunner gameRunner = new GameRunner(gameStatus.PlayersCount, gameStatus.DicesCount);
            gameStatus.Winner = gameRunner.RunGame();



            // TO DO :  Game over,

            // TO DO :  restart?

            Console.ReadKey();
        }



    }
}
