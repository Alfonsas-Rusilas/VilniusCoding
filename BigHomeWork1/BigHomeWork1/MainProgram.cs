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
            //Console.WriteLine($"ChangeNumberToText(string {value})");
            string words = ""; // skaičiaus vertimas į sakinį; 
            bool isDone = false; //ar pilnai išverstas
            int numDigits = value.Length; // kiek skaitmenų skaičiuje
            int pos = 0;
            String place = ""; // šimtai, tūkstančiai ir t.t. 
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
                    place = (value[0] == '1') ? (" Šimtas ") : (" Šimtai ");
                    break;
                case 4://tūkstančių rėžiai
                case 5:
                case 6:
                    pos = (numDigits % 4) + 1;
                    //Console.WriteLine($"Case 4,5,6: skilčių: {pos}; skaičius {value}");
                    place = TukstancioLinksnis(value);
                    break;
                case 7://milijonai
                case 8:
                case 9:
                    pos = (numDigits % 7) + 1;
                    //Console.WriteLine($"Case 9: skilčių: {pos}; skaičius {value}");
                    place = " Mil. "; 
                    break;
                case 10:
                case 11:
                case 12:
                    pos = (numDigits % 10) + 1;
                    //Console.WriteLine($"Case 9: skilčių: {pos}; skaičius {value}");
                    place = " Bil. ";
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
            return words;
        }

        static string TukstancioLinksnis(string val)
        {
            string linksnis = " Tūkst. ";
            if (val.Length==4)
            {
                linksnis = (val[0] == '1') ? (" Tūkstantis ") : (" Tūkstančiai ");
            }
            else if (val.Length == 5)
            {
                linksnis = (val[0] == '1') ? (" Tūkstančių ") : (val[1]=='0')?(" Tūkstančių ") :(" Tūkstančiai ");
            }
            else if (val.Length == 6)
            {
                linksnis = (val[1] == '1') ? (" Tūkstančių ") : (val[2] == '1') ? (" Tūkstantis ") : (val[2] == '0') ? (" Tūkstančių "):(" Tūkstančiai ");
            }
            return linksnis;
        }

        static string Ones(string val)
        {
            String[] units = {"Nulis","Vienas", "Du", "Trys", "Keturi", "Penki", "Šeši", "Septyni", "Aštuoni", "Devyni" };
            return units[Convert.ToInt32(val)];
        }

        static string Tens(string val)
        {
            string names = "";
            switch (Convert.ToInt32(val))
            {
                case 10:
                    names = "Dešimt";
                    break;
                case 11:
                    names = "Vienuolika";
                    break;
                case 12:
                    names = "Dvylika";
                    break;
                case 13:
                    names = "Trylika";
                    break;
                case 14:
                    names = "Keturiolika";
                    break;
                case 15:
                    names = "Penkiolika";
                    break;
                case 16:
                    names = "Šešiolika";
                    break;
                case 17:
                    names = "Septyniolika";
                    break;
                case 18:
                    names = "Aštuoniolika";
                    break;
                case 19:
                    names = "Devyniolika";
                    break;
                case 20:
                    names = "Dvidešimt";
                    break;
                case 30:
                    names = "Trisdešimt";
                    break;
                case 40:
                    names = "Keturiasdešimt";
                    break;
                case 50:
                    names = "Penkiasdešimt";
                    break;
                case 60:
                    names = "Šešiasdešimt";
                    break;
                case 70:
                    names = "Septyniasdešimt";
                    break;
                case 80:
                    names = "Aštuoniasdešimt";
                    break;
                case 90:
                    names = "Devyniasdešimt";
                    break;
                default:
                    names = Tens(val.Substring(0, 1) + "0") + " " + Ones(val.Substring(1));
                    break;
            }
            return names;
        }

        static bool IsCorrectInt(string str, ref string minus, ref string val_str)
        {
            if (str == "" || str == "-")
            {
                return false;
            }
            
            if (str[0]=='-')
            {
                minus = "Minus";
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
            val_str = str;
            return true;
        }

        static bool IsCorrectInt(string str)
        {
            if (str == "" || str == "-")
            {
                return false;
            }
            if (str[0] == '-')
            {
                str = str[1..];
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
