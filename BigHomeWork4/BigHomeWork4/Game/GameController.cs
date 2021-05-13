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
        //private Player player;

        public GameController()
        {
            gameStatus = new GameStatus();
        }

        public void StartGame()
        {

            // TO DO : Players Select Count
            playerSelectionController = new PlayerSelectionController();

            gameStatus.PlayersCount = playerSelectionController.GetPlayersCount();

            //player.SelectPlayersCount();

            // TO DO :  DiecesSelect

            // TO DO :  Run..

            // TO DO :  Game over,

            // TO DO :  restart?
        }



    }
}
