using Lesson18.Uzduotis1;
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

            //Func<int, int> myFunct2 = test => test % 2 == 1;


            // Šiuo atveju C# sukurs keletą funkcijų atmintyje, bet mums užtenka apsirašyti vieną kartą:
            Print("aa", 2);
            Print("aa", true);

            Print2("bb", new Student());

        }

        private static void Print<T>(string v1, T data)
        {
            Console.WriteLine(v1);
            Console.WriteLine(data);
        }

        private static void Print2<T>(string v1, T data) where T : Student
        {
            Console.WriteLine(v1);
            Console.WriteLine(data.Name);
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
