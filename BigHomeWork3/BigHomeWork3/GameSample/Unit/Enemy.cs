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
        public char symb { set; get; }

        public Enemy(int id, string name, char c, int x, int y) : base(name, x, y)
        {
            this.id = id;
            this.symb = c;
        }

        public void MoveDown()
        {
            Y--;

            // jei atsiremiam į kairę sieną, išeiname
            //if (frame.X <= x + 1)
            //{
            //    return;
            //}
            frame.ClearRender();
            frame.X--;
            Label.X--;
            Render();
        }

        public int GetId()
        {
            return id;
        }

        public void ClearRender()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(" ");
        }

    }


}
