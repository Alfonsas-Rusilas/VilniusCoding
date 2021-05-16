using BigHomeWork4.GameStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Gui
{
    class Player : GuiObject
    {
        private TextLine PlayerName;
        private ScoresFrame ScoresBox;
        private List<Dice> Dices;
        public int DicesCount { private set; get; }
        public int Scores { get; set; } = 0;

        public Player(int x, int y, int width, int height, string name, int DicesCount) : base (x,y,width,height)
        {
            this.DicesCount = DicesCount;
            int tempy = y;
            PlayerName = new TextLine(x, y, width, FormatName(name));
            tempy = tempy + 2; 
            ScoresBox = new ScoresFrame(x, tempy, width, height, "Scores:\n0");
            tempy = tempy + ScoresBox.GetHeight()+ 1;
            Dices = new List<Dice>();
            for (int i = 0; i < DicesCount; i++)
            {
                Dices.Add(new Dice(x, tempy, width, 1, "Dice-?"));
                tempy = tempy + Dices[i].GetDiceHight() + 1;
            }
        }

        public override void Render()
        {
            PlayerName.Render();
            ScoresBox.Render();
            foreach (var dice in Dices)
            {
                dice.Render();
            }
        }

        private string FormatName(string name)
        {
            string str = "";
            str = name.Substring(0, (name.Length >= Width - 4) ? (Width - 4) : (name.Length));
            int a = 1;
            while (str.Length < Width - 4)
            {
                str = (a < 0) ? str + " " : " " + str;
                a *= (-1);
            }
            return str;
        }

        public int GetDiceScore(int DiceIndex)
        {
            return Dices[DiceIndex].DiceMove();
        }

        public void UpdateDice(int DiceIndex, string NewLabel)
        {
            Dices[DiceIndex].SetLabel(NewLabel);
            Dices[DiceIndex].Render();
        }

        public void UpdateScores(int score)
        {
            Scores += score;
            ScoresBox.SetName("Scores:\n" + Scores);
            ScoresBox.Render();
        }

        public string GetPlayerName()
        {
            return PlayerName.Label.Trim();
        }
    }
}
