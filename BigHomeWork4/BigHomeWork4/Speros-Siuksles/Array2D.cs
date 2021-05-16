using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Speros
{
    class Array2D
    {
        static void Main(string[] args)
        {
            //Creating an jagged array with four rows
            int[][] arr = new int[3][];
            //Initializing each row with different column size
            // Uisng one dimensional array
            arr[0] = new int[4];
            arr[1] = new int[4];
            arr[2] = new int[4];
            //arr[3] = new int[4];
            //printing the values of jagged array using nested for loop
            //It will print the default values as we are assigning any
            //values to the array
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"arr[{i},{j}]={arr[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //assigning values to the jagged array by using nested for loop
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = j++;
                }
            }
            //print values the values of jagged array by using foreach loop within for loop
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                foreach (int x in arr[i])
                {
                    Console.Write($"x={x}; ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
