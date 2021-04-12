using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Lesson6
{
    class Lesson6
    {
        static void Main(string[] args)
        {
            //String[] zodziai = { "Nulis", "Vienas", "Du", "Trys", "Keturi", "Penki", "Šeši", "Septyni", "Aštuoni", "Devyni" };
            //string[] ss = {"T0", "G1", "E3"};
            //int[] i = new int[3] { 1, 5, 4 };
            //int[] z = new int[10000];
            //char[] letters = { 'A', 'B', 'C', 'D'};
            //string alphabet = new string(letters);
            //Console.WriteLine($"Hello: {zodziai[2]}, {ss[2]}, {alphabet}");
            // int index = s3.IndexOf("C");


            //String[] str = { "Nulis", "Vienas", "Du", "Trys", "Keturi", "Penki=\u00E7", "A@@@@####$%^&*[]]}AA\n\tBBB\n\\CCC\nDDD" };
            //str[6] = str[6] + "\\\\\\__";
            //Console.WriteLine($"Hello: {str[6]}, {str[5]}");


            //////////////////// 6.a 

            string[] str_mas = WriteWords();
            string str = "";
            for (int i = 0; i < str_mas.Length; i++)
            {
                str += str_mas[i];
            }
            Console.WriteLine($"Suvedėt: {str}");
            str = "";
            for (int i = str_mas.Length-1; i >= 0; i--)
            {
                str += str_mas[i];
            }
            Console.WriteLine($"Suvedimas atvirkščiai: {str}");

            RemoveArrayDuplicates(new string[] { "Mano", "batai", "Mano", "buvo", "batai", "buvo", "du", "buvo", "du", "." } );
        }

        static string[] WriteWords()
        {
            string[] tmp = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Įveskite {i+1} žodį: ");
                tmp[i] = Convert.ToString(Console.ReadLine());
            }
            return tmp;
        }

        static void RemoveArrayDuplicates(string[] str)
        {
            string tmp = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i]==str[j])
                    {
                        str[j] = "!";
                    }
                }
            }
            tmp = "";
            for (int m = 0; m < str.Length; m++)
            {
                tmp += " " + str[m];
            }
            Console.WriteLine($"Turime: {tmp}");

            int sk = str.Length - 1;
            for (int m = 0; m < str.Length; m++)
            {
                if (str[m] == "!")
                {
                    string some = str[m];
                    str[sk] = str[m];
                    str[m] = some;
                    sk--;
                }
            }
            for (int m = 0; m < str.Length; m++)
            {
                tmp += " " + str[m];
            }
            Console.WriteLine($"Turime sutvarkytą: {tmp}");
        }

    }
}
