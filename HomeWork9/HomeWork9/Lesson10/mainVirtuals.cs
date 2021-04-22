using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson10
{
    class mainVirtuals
    {

        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.Alfa();
            parent.Beta();
            parent.Gama();

            Child ch = new Child();
            ch.Alfa();
            ch.Beta();
            ch.Gama();

            Parent par = ch;
            par.Alfa();
            par.Beta();
            par.Gama();

        }
    }
}
