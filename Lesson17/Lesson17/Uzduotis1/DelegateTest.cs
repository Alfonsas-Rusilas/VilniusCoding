using Lesson17.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Rinkiniai2
{
    class DelegateTest
    {


        public void DoStuff()
        {
            MyDelegate myDelegate1 = Console.WriteLine;
            MyDelegate myDelegate2 = WriteToFile;

            myDelegate1("hi");
            myDelegate2("Do stuff..");

            MyDelegate myDelegate3 = Console.WriteLine;
            myDelegate3 += WriteToFile;
            myDelegate3("multi delegate!");

            myDelegate3 -= Console.WriteLine;
            myDelegate3("multi delegate test 2!");



        }

        public void WriteToFile(string msg)
        {
            Console.WriteLine("Write to file" + msg);
        }


    }
}
