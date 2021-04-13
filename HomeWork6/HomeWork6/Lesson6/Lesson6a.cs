using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Lesson6
{
    class Lesson6a
    {
        static void Main(string[] args)
        {
            // teorija:
            //String[] zodziai = { "Nulis", "Vienas", "Du", "Trys", "Keturi", "Penki", "Šeši", "Septyni", "Aštuoni", "Devyni" };
            //string[] ss = {"T0", "G1", "E3"};
            //int[] i = new int[3] { 1, 5, 4 };
            //int[] z = new int[10000];
            //char[] letters = { 'A', 'B', 'C', 'D'};
            //string alphabet = new string(letters);
            //Console.WriteLine($"Hello: {zodziai[2]}, {ss[2]}, {alphabet}");
            // int index = s3.IndexOf("C");

            //////////////////// 6.a ////////////////////
            string[] str_mas = GetWords();
            string str = "";
            Console.WriteLine($"Suvedėt: {PrintArray(str_mas, " ")}");
            for (int i = str_mas.Length-1; i >= 0; i--)
            {
                str += str_mas[i];
            }
            Console.WriteLine($"Suvedimas atvirkščiai: {str}");
            RemoveArrayDuplicates(new string[] { "Mano", "batai", "Mano", "buvo", "batai", "buvo", "du", "buvo", "du", "." } );

            //////////////////// 6.b //////////////////// namų darbams - 6.b ir 6.c
            // int[] numbers = {1,3,5}
            // foreach (int item in numbers) {....} //veikia break, continue
            // SendData(int a, string str, params int[] numb) //jei norime perduoti nežinomą kiekį, galime gale naudoti
            // Netipizuoti parametrai: SendData(params object[] num) //objektas c# gali būti int, bool, etc.


            //////////////////// 6.d //////////////////// namų darbams - array klasė, ir 6.d
            // string[,] names;
            // int[,] a = new int[3,4] {{..} {..} {..}}
            // Geriau naudoti masyvus masyvuose:
            // int[][] scores;
            // int[][] scores = new int[][] {
            //     new int[] {93,94,95},
            //     new int[] {3,4,5} };

        }


        static string[] GetWords()
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
            string sign = "!";
            int signs = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && (str[i]!=sign))
                    {
                        str[j] = sign;
                        signs++;
                    }
                }
            }
            Console.WriteLine($"Turime: {PrintArray(str, " ")}");
            
            int sk = 0;
            string[] str_els = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                str_els[i] = sign;
                if (str[i] != sign)
                {
                    str_els[sk++] = str[i];
                }
            }
            Console.WriteLine($"Turime sutvarkytą: {PrintArray(str_els, " ")}");
        }

        static string PrintArray(string[] str_array,  string delimiter = " ")
        {
            string tmp = "";
            for (int m = 0; m < str_array.Length; m++)
            {
                tmp += " " + str_array[m];
            }
            return tmp;
        }

    }
}
