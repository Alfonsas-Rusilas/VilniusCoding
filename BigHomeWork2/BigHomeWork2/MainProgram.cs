using System;
using System.Linq;
using System.Collections.Generic;

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
            List<int> magicNumbersList = new List<int>(); 
            Console.WriteLine($"Ieškosime stebuklingų skaičių tarp {MinMagicNum} iki {MaxMagicNum}.");
            int multiplier = 6;
            do
            {
                masyvas1 = DigitsToArray(currentNum);
                if (IsDigitsDifferent(masyvas1))
                {
                    int IsMagicNumber = 0;
                    for (int i = 2; i <= 6; i++)
                    {
                        masyvas2 = DigitsToArray(currentNum * i);
                         if (CompareArrays(masyvas1, masyvas2))
                        {
                            IsMagicNumber++;
                        } else
                        {
                            break;
                        }
                    }
                    // Jei patikrinom ir buvo true 5 kartus, tai magic skaičių įkeliame į sąrašą:
                    if (IsMagicNumber == 5)
                    {
                        magicNumbersList.Add(currentNum);
                    }
                }
                currentNum++;
            } while ((currentNum <= MaxMagicNum) && (multiplier * currentNum) <= MaxMagicNum );

            // Išvedame rastus magic skaičius:
            for (int i = 0; i < magicNumbersList.Count; i++)
            {
                for (int x = 1; x <= 6; x++)
                {
                    PrintArray(DigitsToArray(magicNumbersList[i] * x), "Masyvas" + i);
                }
            }
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
