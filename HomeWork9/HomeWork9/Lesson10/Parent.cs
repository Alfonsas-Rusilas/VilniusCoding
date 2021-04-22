using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson10
{
    class Parent
    {
        public Parent()
        {
            //
        }

        public virtual void Alfa()
        {
            Console.WriteLine("Parent.alfa");
        }

        public virtual void Beta()
        {
            Console.WriteLine("Parent.beta");
        }

        public virtual void Gama()
        {
            Console.WriteLine("Parent.gama");
        }
    }
}
