using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    class Dog : Pet
    {
        private string name;


        public Dog(int lspan, string name) : base(lspan)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
