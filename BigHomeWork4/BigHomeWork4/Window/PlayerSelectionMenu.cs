using BigHomeWork4.Game;
using BigHomeWork4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Window
{
    class PlayerSelectionController
    {
        private int PlayersCount = 0;

        private List<BoxFrame> BoxFrames;
        
        public BoxFrame bf;


        public PlayerSelectionController()
        {
            //BoxFrames = new List<BoxFrame>()
            //{
            //    new BoxFrame(BoxType.TypeP2, 4,4,10,5,"P2",false)
            //};

            
        }

        public int GetPlayersCount()
        {
            bf = new BoxFrame(BoxType.TypeP7, 4, 4, 10, 5, "Player7", false);
            bf.Render();

            Console.ReadKey();

            // Nupiešk meniu




            // Vaikščiok su mygtukais



            // grąžink žaidėjų skaičių:
            return 2;
        }





    }
}
