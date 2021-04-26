using HomeWork12.Lesson12.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Lesson12.Animals
{


    class Pet : Animal, IMoovable, IRenderable //, IEnumerable
    {
        private int x;
        public int X { get { return x; }  set { x = value; } }
        public int Y { get; set; }

        public void Move()
        {
            //
        }

        public void Render()
        {
            //
        }

    }
}
