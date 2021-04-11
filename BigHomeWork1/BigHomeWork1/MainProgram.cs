using System;

namespace BigHomeWork1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            bool valueWithMinus = false;
            int valuePositive = 0;

            Console.Write("Įveskite skaičių: ");
            string str = Convert.ToString(Console.ReadLine());

            bool some = IsCorrectInt(str, ref valueWithMinus, ref valuePositive);
            Console.WriteLine($"Skaičius teisingas? - {some}; ar su minusu? - {valueWithMinus}");
        }

        static bool IsCorrectInt(string str, ref bool minus, ref int val)
        {
            if (str == "" || str == "-")
            {
                return false;
            }
            
            if (str[0]=='-')
            {
                minus = true;
                str = str[1..];
            }

            for (int i = 0; i < str.Length; i++)
            {
                byte asci = (byte)str[i];
                if (asci<48 || asci>57)
                {
                    return false;
                }
            }
            val = Convert.ToInt32(str);
            return true;
        }
    }
}
