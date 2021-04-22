using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson10
{
    class Child : Parent
    {
        public Child() : base()
        {
            //
        }

        public new void Alfa()
        {
            Console.WriteLine("Child.alfa");
            //base.Alfa();
        }

        public override void Beta()
        {
            Console.WriteLine("Child.beta");
            //base.
        }

        public override void Gama()
        {
            Console.WriteLine("Child.gama");
        }

    }
}
