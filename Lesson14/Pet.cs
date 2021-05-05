using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    class Pet : LiveObject, IPrintMe
    {

        public Pet(int lifespan) : base(lifespan)
        {
            //
        }



        public void PrintInfo()
        {
            Console.WriteLine("Pet class");
        }
    }
}
