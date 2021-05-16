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
            MenuReturnType rtype = MenuReturnType.None;
            do
            {
                // TO DO : Players Select Count
                Console.Clear();
                playerSelectionController = new PlayerSelectionController();
                gameStatus.PlayersCount = playerSelectionController.GetPlayersCount();

                // TO DO :  DiecesSelect
                diceSelectionController = new DiceSelectionController();
                gameStatus.DicesCount = diceSelectionController.GetDiceCount();
                //Console.WriteLine($"Pasirinkta {gameStatus.DicesCount}");

                // TO DO :  Run action..
                GameRunner gameRunner = new GameRunner(gameStatus.PlayersCount, gameStatus.DicesCount);
                rtype = gameRunner.RunGame();
            } while (rtype == MenuReturnType.ReplayGame);
        }

    }
}
