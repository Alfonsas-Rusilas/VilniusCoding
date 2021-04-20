using System;

namespace BigHomeWork2
{
    class MainProgram
    {
        static int tmpArrayLength = 10;
        static int[] tmp_mas = new int[tmpArrayLength]; 

        static void Main(string[] args)
        {
            int[] masyvas1 = new int[6];
            int[] masyvas2 = new int[6];
            

            

            Console.Write("Įveskite skaičių iš 6 skaitmenų: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            masyvas1 = DigitsToArray(skaicius);
            masyvas2 = DigitsToArray(skaicius-1);

            CompareArrays(masyvas1, masyvas2);

            //if (IsDigitsDifferent(masyvas1)==false)
            //{
            //    Console.WriteLine("Yra pasikartojimų: ");
            //    PrintArray(masyvas1);
            //}
            //separateDigits(skaicius);
        }

        static int[] DigitsToArray(int value)
        {
            int index = 5;
            int[] ret = new int[index+1];
            while (value > 9)
            {
                ret.SetValue(value % 10, index--);
                value /= 10;
            }
            ret.SetValue(value, index);
            return ret;
        }

        /*
        static void separateDigits(int n)
        {
            if (n < 10)
            {
                Console.Write("{0}  ", n);
                return;
            }
            separateDigits(n / 10);
            Console.Write(" {0} ", n % 10);
        }
        */

        static bool IsDigitsDifferent(int[] mas)
        {
            Array.Clear(tmp_mas, 0, tmpArrayLength);
            foreach (int item in mas)
            {
                if (++tmp_mas[item] > 1) return false; 
            }
            return true;
        }

        static bool CompareArrays(int[] mas1, int[] mas2)
        {
            int sk1 = 0;
            int sk2 = 0;
            Array.Clear(tmp_mas, 0, tmpArrayLength);
            for (int i = 0; i < mas1.Length; i++)
            {
                tmp_mas[mas1[i]]++;
                tmp_mas[mas2[i]]++;
            }
            foreach (int item in tmp_mas)
            {
                if (item != 0 && item != 2)
                {
                    sk1++;
                }
                    
            }
            return true;
        }

        static void PrintArray(int[] mas)
        {
            string str = "";
            foreach (int item in mas)
            {
                str += " " + item;
            }
            Console.WriteLine("Masyvas: " + str);
        }
    }
}
