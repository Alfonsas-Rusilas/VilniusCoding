using System;

namespace BigHomeWork1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            string valueMinus = "";
            string valueStrPositive = "";

            Console.Write("Įveskite skaičių: ");
            string str = Convert.ToString(Console.ReadLine());

            while (IsCorrectInt(str, ref valueMinus, ref valueStrPositive))
            {
                Console.WriteLine($"{valueMinus} {ChangeNumberToText(valueStrPositive)}");
                Console.Write("Įveskite kitą skaičių: ");
                str = Convert.ToString(Console.ReadLine());
            }
        }

        static string ChangeNumberToText(string value)
        {
            string words = "";      //skaičiaus vertimas į sakinį; 
            bool isDone = false;    //ar pilnai išverstas
            int numDigits = value.Length; // kiek skaitmenų skaičiuje
            int pos = 0;
            String place = "";      // šimtai, tūkstančiai ir t.t. 
            switch (numDigits)
            {
                case 1:
                    words = Ones(value);
                    isDone = true;
                    break;
                case 2:
                    words = Tens(value);
                    isDone = true;
                    break;
                case 3: //šimtų rėžiai    
                    pos = (numDigits % 3) + 1;
                    //Console.WriteLine($"Case 3; skilčių: {pos}; skaičius {value}");
                    place = (value[0] == '1') ? (" šimtas ") : (" šimtai ");
                    break;
                case 4://tūkstančių rėžiai
                case 5:
                case 6:
                    pos = (numDigits % 4) + 1;
                    //Console.WriteLine($"Case 4,5,6: skilčių: {pos}; skaičius {value}");
                    place = Linksnis(value);
                    break;
                case 7://milijonai
                case 8:
                case 9:
                    pos = (numDigits % 7) + 1;
                    //Console.WriteLine($"Case 9: skilčių: {pos}; skaičius {value}");
                    place = Linksnis(value); 
                    break;
                case 10:
                case 11:
                case 12:
                    pos = (numDigits % 10) + 1;
                    //Console.WriteLine($"Case 9: skilčių: {pos}; skaičius {value}");
                    place = Linksnis(value);
                    break;
                default:
                    isDone = true;
                    break;
            }
            if (!isDone)
            {
                if (value.Substring(0, pos) != "0" && value.Substring(pos) != "0")
                {
                     words = ChangeNumberToText(value.Substring(0, pos)) + place + ChangeNumberToText(EliminateZerosInBeginning(value.Substring(pos)));
                }
                else
                {
                    words = ChangeNumberToText(value.Substring(0, pos)) + ChangeNumberToText(value.Substring(pos));
                }
            }
            return FirstLetterUp(words);
        }

        static string FirstLetterUp(string firstLetter)
        {
            if (string.IsNullOrEmpty(firstLetter))
            {
                return string.Empty;
            }
            firstLetter = firstLetter.Trim(' ');
            firstLetter = firstLetter.ToLower();
            return char.ToUpper(firstLetter[0]) + firstLetter.Substring(1);
        }

        static string Linksnis(string val)
        {
            string linksnis;
            switch (val.Length)
            {
                case 4:
                    linksnis = (val[0] == '1') ? (" tūkstantis ") : (" tūkstančiai ");
                    break;
                case 5:
                    linksnis = (val[0] == '1') ? (" tūkstančių ") : (val[1] == '0') ? (" tūkstančių ") : (val[1] == '1') ? (" tūkstantis ") : (" tūkstančiai ");
                    break;
                case 6:
                    linksnis = (val[1] == '1') ? (" tūkstančių ") : (val[2] == '1') ? (" tūkstantis ") : (val[2] == '0') ? (" tūkstančių ") : (" tūkstančiai ");
                    break;
                case 7:
                    linksnis = (val[0] == '1') ? (" milionas ") : (" milionai ");
                    break;
                case 8:
                    linksnis = (val[0] == '1') ? (" milionų ") : (val[1] == '0') ? (" milionų ") : (val[1] == '1') ? (" milionas ") : (" milionai ");
                    break;
                case 9:
                    linksnis = (val[1] == '1') ? (" milionų ") : (val[2] == '1') ? (" milionas ") : (val[2] == '0') ? (" milionų ") : (" milionai ");
                    break;
                case 10:
                    linksnis = (val[0] == '1') ? (" bilionas ") : (" bilionai ");
                    break;
                case 11:
                    linksnis = (val[0] == '1') ? (" bilionų ") : (val[1] == '0') ? (" bilionų ") : (val[1] == '1') ? (" bilionas ") : (" bilionai ");
                    break;
                case 12:
                    linksnis = (val[1] == '1') ? (" bilionų ") : (val[2] == '1') ? (" bilionas ") : (val[2] == '0') ? (" bilionų ") : (" bilionai ");
                    break;
                default:
                    linksnis = "";
                    break;
            }
            return linksnis;
        }

        static string Ones(string val)
        {
            String[] units = {"nulis","vienas", "du", "trys", "keturi", "penki", "šeši", "septyni", "aštuoni", "devyni"};
            return units[Convert.ToInt32(val)];
        }

        static string Tens(string val)
        {
            string names = "";
            switch (Convert.ToInt32(val))
            {
                case 10:
                    names = "dešimt";
                    break;
                case 11:
                    names = "vienuolika";
                    break;
                case 12:
                    names = "dvylika";
                    break;
                case 13:
                    names = "trylika";
                    break;
                case 14:
                    names = "keturiolika";
                    break;
                case 15:
                    names = "penkiolika";
                    break;
                case 16:
                    names = "šešiolika";
                    break;
                case 17:
                    names = "septyniolika";
                    break;
                case 18:
                    names = "aštuoniolika";
                    break;
                case 19:
                    names = "devyniolika";
                    break;
                case 20:
                    names = "dvidešimt";
                    break;
                case 30:
                    names = "trisdešimt";
                    break;
                case 40:
                    names = "keturiasdešimt";
                    break;
                case 50:
                    names = "penkiasdešimt";
                    break;
                case 60:
                    names = "šešiasdešimt";
                    break;
                case 70:
                    names = "septyniasdešimt";
                    break;
                case 80:
                    names = "aštuoniasdešimt";
                    break;
                case 90:
                    names = "devyniasdešimt";
                    break;
                default:
                    names = Tens(val.Substring(0, 1) + "0") + " " + Ones(val.Substring(1));
                    break;
            }
            return names;
        }

        static bool IsCorrectInt(string str, ref string minus, ref string val_str)
        {
            if (string.IsNullOrEmpty(str) || str == "-" || str.Length > 12)
            {
                return false;
            }
            if (str[0]=='-')
            {
                minus = "Minus";
                str = str[1..];
            }
            if (str[0] == '0')
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                byte asci = (byte)str[i];
                if (asci<48 || asci>57)
                {
                    return false;
                }
            }
            val_str = str;
            return true;
        }

        static bool IsCorrectInt(string str)
        {
            if (string.IsNullOrEmpty(str) || str == "-" || str.Length > 12)
            {
                return false;
            }
            if (str[0] == '-')
            {
                str = str[1..];
            }
            if (str[0] == '0')
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                byte asci = (byte)str[i];
                if (asci < 48 || asci > 57)
                {
                    return false;
                }
            }
            return true;
        }

        static string EliminateZerosInBeginning(string str)
        {
            while (str.StartsWith('0') && str.Length > 0)
            {
                str = str.Remove(0, 1);
            }
            return str;
        }
    }
}
