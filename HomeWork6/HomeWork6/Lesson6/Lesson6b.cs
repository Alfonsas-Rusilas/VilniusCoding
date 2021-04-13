using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Lesson6
{
    class _6b
    {
        static void Main(string[] args)
        {
            //int[] manoNuostabusisMasyvas = { 111, 222, 333 };
            //Console.WriteLine(manoNuostabusisMasyvas[0] + ", " + manoNuostabusisMasyvas[1] + ", " + manoNuostabusisMasyvas[2]);
            //sugadinkMasyva(manoNuostabusisMasyvas);
            //Console.WriteLine(manoNuostabusisMasyvas[0] + ", " + manoNuostabusisMasyvas[1] + ", " + manoNuostabusisMasyvas[2]);
            ArrayReferenceTest();


        }

        static void ArrayReferenceTest()
        {
            int[] manoMasyvas = { 111, 222, 333 , 444, 555};
            foreach (var item in manoMasyvas)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int[] temp = (int[])manoMasyvas.Clone(); 

            SpoilArray(manoMasyvas);
            foreach (var item in manoMasyvas)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            manoMasyvas = (int[])temp.Clone();
            Console.WriteLine(PrintArray(manoMasyvas, " "));
        }

        static void SpoilArray(int[] masyvas)
        {
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = -1;
            }
        }

        private static void sugadinkMasyva(int[] manoNuostabusisMasyvas)
        {
            manoNuostabusisMasyvas[0] = -1;
            manoNuostabusisMasyvas[1] = -1;
            manoNuostabusisMasyvas[2] = -1;
        }

        static string PrintArray(string[] str_array, string delimiter = " ")
        {
            string tmp = "";
            foreach  (string item in str_array)
            {
                tmp += " " + item;
            }
            return tmp;
        }

        static string PrintArray(int[] int_array, string delimiter = " ")
        {
            string tmp = "";
            foreach (int item in int_array)
            {
                tmp += " " + item;
            }
            return tmp;
        }

    }
}
