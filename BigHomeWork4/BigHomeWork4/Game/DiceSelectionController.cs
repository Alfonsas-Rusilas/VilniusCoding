using BigHomeWork4.Game;
using BigHomeWork4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Window
{
    class DiceSelectionController
    {
        private int DiceCount;
        private const int MaxDiceCount = 9;
        private const int MinDiceCount = 3;
        private const int DiceSelectionBoxWidth = 40;
        private const int DiceSelectionBoxHeight = 7;

        private BoxFrame boxFrame;

        public DiceSelectionController()
        {
            Console.Clear();
            DiceCount = MinDiceCount;
            boxFrame = new BoxFrame(Game.BoxType.None, (App.ScreenWidth- DiceSelectionBoxWidth)/2, (App.ScreenHeight/2),
                DiceSelectionBoxWidth, DiceSelectionBoxHeight, "Players will have 3 dice (+ or -)");
        }

        public void Render()
        {
            boxFrame.Render();
        }


        public int GetDiceCount()
        {
            Render();
            // Su mygtukais + ir -, ir grąžink Dice pasirinikimą
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Subtract:
                        DecrementDiceCount();
                        break;
                    case ConsoleKey.Add:
                        IncrementDiceCount();
                        break;
                    case ConsoleKey.Enter:
                        return DiceCount;
                }
            } while (pressedChar.Key != ConsoleKey.Escape);
            return DiceCount;
        }

        private void IncrementDiceCount()
        {
            if (DiceCount < MaxDiceCount)
            {
                DiceCount++;
                boxFrame.SetName("Players will have " + DiceCount + " dice (+ or -)");
                Render();
            }
        }

        private void DecrementDiceCount()
        {
            if (DiceCount > MinDiceCount)
            {
                DiceCount--;
                boxFrame.SetName("Players will have " + DiceCount + " dice (+ or -)");
                Render();
            }
        }
    }



}
