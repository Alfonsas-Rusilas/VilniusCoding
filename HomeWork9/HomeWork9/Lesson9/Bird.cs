using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson9
{
    class Bird : Animal
    {
        private string featherColor;

        public Bird(int lifeSpan, string featherColor) : base(lifeSpan)
        {
            this.featherColor = featherColor;
        }

        public void Fly()
        {
            //
        }

    }
}
