using BigHomeWork3.GameSample.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Unit
{
    class Enemy : Unit
    {
        private readonly int id;
        private int Speed;
        public bool MarkForDelete { set; get; } = false;
        public char CurrentSymbol { set; get; }

        private List<char> Chars = new List<char>();

        public Enemy(int id, string name, int x, int y) : base(name, x, y)
        {
            this.id = id;
            Random rnd = new Random();
            Speed = rnd.Next(AppSettings.EnemiesMoovingSpeed);
            Chars.AddRange("Oo0©");
            this.CurrentSymbol = Chars[0];
        }

        public void MoveDown()
        {
            Random val = new Random();
            int b = val.Next(3);
            int CharsCount = Chars.Count;
            if (b>0)
            {
                this.CurrentSymbol = Chars[val.Next(CharsCount)];
                if (Y >= AppSettings.GameScreenHeight - 2)
                {
                    ClearRender();
                    return;
                }
                if ((Speed--) <= 0)
                {
                    ClearRender();
                    Y++;
                    Render();
                    Speed = AppSettings.EnemiesMoovingSpeed;
                }
            }
        }

        public void MoveArround()
        {
            ClearRender();
            Random rnd = new Random();
            CurrentSymbol = (char)rnd.Next(33, 254);
            Render();
        }

        public int GetId()
        {
            return id;
        }

        public void Render()
        {
            //ClearRender();
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(CurrentSymbol);
        }

        public void ClearRender()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(" ");
        }

    }


}
