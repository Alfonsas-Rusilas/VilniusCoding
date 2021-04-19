using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson9
{
    class Fish : Animal
    {
        private int data;

        public Fish(int lifeSpan, int data) : base(lifeSpan)
        {
            this.data = data;
        }

        public void Swim()
        {
            //
        }
    }
}
