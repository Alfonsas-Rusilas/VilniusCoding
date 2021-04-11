﻿using System;

namespace BigHomeWork1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            bool valueWithMinus = false;
            //int valueIntPositive = 0;
            string valueStrPositive = "";

            Console.Write("Įveskite skaičių: ");
            string str = Convert.ToString(Console.ReadLine());

            bool some = IsCorrectInt(str, ref valueWithMinus, ref valueStrPositive);
            Console.WriteLine($"Skaičius teisingas? - {some}; ar su minusu? - {valueWithMinus}");
            Console.WriteLine($"Skaičius {valueStrPositive} išreikštas žodžiais: {ChangeNumberToText(valueStrPositive)}");
        }

        static string ChangeNumberToText(string value)
        {
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
                    place = " Šimtai ";
                    break;
                default:
                    isDone = true;
                    break;
            }
            if (!isDone)
            {
                if (value.Substring(0, pos) != "0" && value.Substring(pos) != "0")
                {
                     words = ChangeNumberToText(value.Substring(0, pos)) + place + ChangeNumberToText(value.Substring(pos));
                }
                else
                {
                    words = ChangeNumberToText(value.Substring(0, pos)) + ChangeNumberToText(value.Substring(pos));
                }
            }
            return words;
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

        static bool IsCorrectInt(string str, ref bool minus, ref string val_str)
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
            val_str = str;
            return true;
        }
    }
}