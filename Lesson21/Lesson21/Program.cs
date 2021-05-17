using System;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2 && singleton1 != null)
            {
                Console.WriteLine("Viksas gerai!");
            } else
            {
                Console.WriteLine("Blogai, skirtingi objektai arba tušti");
            }



            //Console.WriteLine("Hello World!");
        }
    }
}
