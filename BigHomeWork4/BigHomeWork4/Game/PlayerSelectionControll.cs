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
        private List<BoxFrame> boxList;
        private int PlayersCount;
        //{Up, Down, Left, Right}
        private int[,] arrow = new int[BoxInLine* BoxLinesCount, 4]
        {{ 3,3,2,1 }, 
        { 4,4,0,2 }, 
        { 5,5,1,0 }, 
        { 0,0,5,4 }, 
        { 1,1,3,5 }, 
        { 2,2,4,3 } };

        public PlayerSelectionController()
        {
            PlayersCount = 2;
            boxList = new List<BoxFrame>();
            Render();
        }

        private void Render()
        {
            // Nupiešk visą box's meniu
            int y = BoxsY;
            int x;
            BoxType bt = BoxType.None;
            for (int b = 0; b < 2; b++)
            {
                x = (App.ScreenWidth - (BoxWidth * BoxInLine + BoxInLine * 2)) / 2;
                for (int i = 0; i < 3; i++)
                {
                    boxList.Add(new BoxFrame(++bt, x, y, BoxWidth, BoxFrame.BoxHeight, bt.ToString(), (i == 0 && b == 0)));
                    boxList[boxList.Count - 1].Render();
                    x = x + BoxWidth + 2;
                }
                y = y + BoxFrame.BoxHeight + 2;
            }
        }

        public int GetPlayersCount()
        {
            // Vaikščiok su mygtukais ir grąžink pasirinikimą
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
                        return PlayersCount; 
                }
            } while (pressedChar.Key != ConsoleKey.Escape);
            return PlayersCount;
        }

        private void MoveFocusOnBoxes(ArrowIndex way)
        {
            int indexA = boxList.FindIndex(bf => bf.IsActive == true);
            int nextIndex = arrow[indexA, (int)way];
            boxList[indexA].IsActive = false;
            boxList[indexA].Render();
            boxList[nextIndex].IsActive = true;
            boxList[nextIndex].Render();
            PlayersCount = nextIndex + 2;
        }


    }
}
