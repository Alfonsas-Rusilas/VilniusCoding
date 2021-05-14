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
        private const int BoxInLine = 3;
        private const int BoxLinesCount = 2;
        private const int BoxsY = 4;
        private const int BoxWidth = 18;
        //private BoxFrame[,] BoxMatrica; // = new BoxFrame[3, 2];
        private List<BoxFrame> boxList;
        ///                                {Up, Down, Left, Right}
        private int[,] arrow = new int[6,4]{{ 3,3,2,1 }, 
                                            { 4,4,0,2 }, 
                                            { 5,5,1,0 }, 
                                            { 0,0,5,4 }, 
                                            { 1,1,3,5 }, 
                                            { 2,2,4,3 } };

        public PlayerSelectionController()
        {
            //BoxMatrica = new BoxFrame[BoxInLine, BoxLinesCount];
            boxList = new List<BoxFrame>();
        }

        public int GetPlayersCount()
        {
            // Nupiešk meniu
            int y = BoxsY;
            int x; 
            BoxType bt = BoxType.None;
            /*
            for (int b = 0; b < 2; b++)
            {
                x = (App.ScreenWidth - (BoxWidth * BoxInLine + BoxInLine * 2)) / 2;
                for (int i = 0; i < 3; i++)
                {
                    BoxMatrica[i,b] = new BoxFrame(++bt, x, y, BoxWidth, BoxFrame.BoxHeight, bt.ToString(), (i==0 && b==0));
                    BoxMatrica[i,b].Render();
                    x = x + BoxWidth + 2;
                }
                y = y + BoxFrame.BoxHeight + 2;
            } */
            for (int b = 0; b < 2; b++)
            {
                x = (App.ScreenWidth - (BoxWidth * BoxInLine + BoxInLine * 2)) / 2;
                for (int i = 0; i < 3; i++)
                {
                    //boxList.Add(new BoxFrame(++bt, x, y, BoxWidth, BoxFrame.BoxHeight, bt.ToString(), (i == 0 && b == 0)));
                    boxList.Add(new BoxFrame(++bt, x, y, BoxWidth, BoxFrame.BoxHeight, "x" + x + " y"+y, (i == 0 && b == 0)));
                    boxList[boxList.Count-1].Render();
                    x = x + BoxWidth + 2;
                }
                y = y + BoxFrame.BoxHeight + 2;
            }
            //foreach (var itemBox in boxList)
            //{
            //    itemBox.Render();
            //}
            //boxList[0].Render();
            //boxList[1].Render();
            //boxList[2].Render();


            //Console.ReadKey();


            // Vaikščiok su mygtukais
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.LeftArrow:
                        MoveFocusOnBoxes(ArrowIndex.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveFocusOnBoxes(ArrowIndex.Right);
                        break;
                    case ConsoleKey.UpArrow:
                        MoveFocusOnBoxes(ArrowIndex.Up);
                        break;
                    case ConsoleKey.DownArrow:
                        MoveFocusOnBoxes(ArrowIndex.Down);
                        break;
                    case ConsoleKey.Enter:
                        //if (guiController.GetActiveButtonLabel() == "Quit")
                        //{
                        //    return;
                        //}
                        //if (guiController.GetActiveButtonLabel() == "Credit")
                        //{
                        //    guiController.ShowCreditMenu();
                        //}
                        //if (guiController.GetActiveButtonLabel() == "Start")
                        //{
                        //    guiController.StartGame();
                        //}
                        //guiController.ShowMenu();
                        break;
                }
            } while (pressedChar.Key != ConsoleKey.Escape);


            // grąžink žaidėjų skaičių:
            return 2;
        }

        private void MoveFocusOnBoxes(ArrowIndex way)
        {
            int indexA = boxList.FindIndex(bf => bf.IsActive == true);
            int nextIndex = arrow[indexA, (int)way];
            boxList[indexA].IsActive = false;
            boxList[indexA].Render();
            boxList[nextIndex].IsActive = true;
            boxList[nextIndex].Render();
        }


    }
}
