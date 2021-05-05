using BigHomeWork3.GameSample.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Unit
{
    class Ball : Unit
    {
        private readonly int id;
        private int Speed = AppSettings.BallMoovingSpeed;
        private static int BallsCount = 0;
        public bool MarkForDelete { set; get; } = false;
        public char CurrentSymbol { set; get; }

        public Ball(string name, char c, int x, int y) : base(name, x, y)
        {
            BallsCount++;
            this.id = BallsCount;
            this.CurrentSymbol = c;
        }

        ~Ball()
        {
            BallsCount--;
        }

        public void MoveUp()
        {
            if (Y <= AppSettings.GameScreenY + 2)
            {
                ClearRender();
                return;
            }
            if ((Speed--) <= 0)
            {
                ClearRender();
                Y--;
                Render();
                Speed = AppSettings.BallMoovingSpeed;
            }
         }


        public int GetId()
        {
            return id;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(CurrentSymbol);
        }

        public void ClearRender()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(" ");
        }

        //public void DeleteBall()
        //{
        //    FlagToDelete = true;
        //}
    }
}
