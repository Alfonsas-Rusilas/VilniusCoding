using Lesson17.Rinkiniai2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Uzduotis1
{
    class MainUzduotis
    {
        static void Main(string[] args)
        {
            DelegateTest delegatetest = new DelegateTest();
            delegatetest.DoStuff();


            DoOperation someOperation = new DoOperation(MyMultiply);

            someOperation += MySum;



        }

        static int MyMultiply(int a1, int a2)
        {
            return a1 * a2;
        }

        static int MySum(int a1, int a2)
        {
            return a1 + a2;
        }
    }
}
