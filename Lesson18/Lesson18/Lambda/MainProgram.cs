using System;
using System.Collections.Generic;

namespace Lesson18
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 1, 2, 3, 4, };

            data.RemoveAll(delegate (int test)
            {
                return test % 2 == 1;
            }
            );

            TestOdd(3);

            data.RemoveAll((int test) =>
            {
                return test % 2 == 1;
            }
            );

            data.RemoveAll((test) =>
            {
                return test % 2 == 1;
            }
            );

            data.RemoveAll(test =>
            {
                return test % 2 == 1;
            }
            );

            data.RemoveAll(test => test % 2 == 1);

            data.RemoveAll(test => { int b = 5; return b % 2 == 1; });

            //data.RemoveAll((int a, int div) => { int b = 5; return b % 2 == 1; });



            Func<string> myFunc = data.ToString;

            Action<int, int> myFunct = TestOperation;

        }

        private static void TestOperation(int arg1, int arg2)
        {
            Console.WriteLine(arg1 + arg2);
        }

        static bool TestOdd(int testNr)
        {
            return testNr % 2 == 2;
        }
    }
}
