﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Lesson4
{
    class Program4
    {
        static void Main()
        {
            //////////////  3.a
            for (int i = 0; i < 20; i += 3)
            {
                Console.WriteLine($"Hi! i is: {i}");
            }


            Console.Write("Įveskite pirmą skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("bad limits");
            }
            else
            {
                for (int i = skaicius1; i < skaicius2; i++)
                {
                    Console.WriteLine($"Ciklas: {i}, kvadratas: {i * i}");
                }
            }

            int suma = 0;
            for (int i = 1000; i > 0; i--)
            {
                if ((i % 3) == 0 || (i % 5 == 0)) suma += i;
            }
            Console.WriteLine($"Hi! suma is: {suma}");
        }
    }
}