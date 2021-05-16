using BigHomeWork4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.GameStatus
{
    class Dice : GuiObject
    {
        public string Label { private set; get; }

        public Dice(int x,int y, int width, int height, string name): base (x,y,width,height)
        {
            Label = FormatName(name);
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Label);
        }

        public int GetDiceHight()
        {
            return 1;
        }

        public void SetLabel(string label)
        {
            Label = FormatName(label);
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

        public int DiceMove()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }

    }
}
