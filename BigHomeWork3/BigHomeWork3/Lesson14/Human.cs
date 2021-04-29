using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    class Human : LiveObject, IPrintMe
    {
        protected string name;

        public Human(int lspan, string name) : base(lspan)
        {
            this.name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Human class");
        }

        public string GetName()
        {
            return name;
        }

    }
}
