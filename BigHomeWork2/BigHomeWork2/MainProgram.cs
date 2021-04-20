using System;
using System.Linq;

namespace BigHomeWork2
{
    class MainProgram
    {
        static int tmpArrayLength = 10;
        static int[] tmp_mas = new int[tmpArrayLength];
        static int MinMagicNum = 100000;
        static int MaxMagicNum = 999999;

        static void Main(string[] args)
        {
            int[] masyvas1 = new int[6];
            int[] masyvas2 = new int[6];
            int currentNum = MinMagicNum;
            Console.WriteLine($"Ieškosime stebuklingų skaičių tarp {MinMagicNum} iki {MaxMagicNum}.");
            Console.Write($"Įveskite daugiklį [2,3,4,5,6]: ");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            do
            {
                masyvas1 = DigitsToArray(currentNum);
                if (IsDigitsDifferent(masyvas1))
                {
                    masyvas2 = DigitsToArray(currentNum * 2);
                    if (CompareArrays(masyvas1, masyvas2))
                    {
                        Console.WriteLine("Turime stebūklą: ");
                        PrintArray(masyvas1, "MasyvasA");
                        for (int i = 2; i <= multiplier; i++)
                        {
                            PrintArray(DigitsToArray(currentNum * i), "Masyvas"+i);
                        }
                    }
                }
                currentNum++;
            } while ((currentNum <= MaxMagicNum) && (multiplier * currentNum) <= MaxMagicNum );
        }

        static int[] DigitsToArray(int value)
        {
            if (value > 999999)
            {
                return null;
            }
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

        static bool IsDigitsDifferent(int[] mas)
        {
            Array.Clear(tmp_mas, 0, tmpArrayLength);
            foreach (int item in mas)
            {
                if (++tmp_mas[item] > 1)
                {
                    return false;
                }
            }
            return true;
        }

        static bool CompareArrays(int[] mas1, int[] mas2)
        {
            if (mas2 == null)
            {
                return false;
            }
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
                    return false;
                }
            }
            return true;
        }

        static void PrintArray(int[] mas, string msg = "")
        {
            string str = "";
            foreach (int item in mas)
            {
                str += " " + item;
            }
            Console.WriteLine($"{msg}: " + str);
        }
    }
}
