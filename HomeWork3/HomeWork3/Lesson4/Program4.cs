using System;
using System.Collections.Generic;

namespace HomeWork3.Lesson4
{
    class Program4
    {
        static void Main()
        {
            //////////////  3.a /////////////////////////////////////////
            /*
            for (int i = 0; i < 20; i += 3)
            {
                Console.WriteLine($"Hi! i is: {i}");
            }

            Console.Write("Įveskite pirmą skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 >= skaicius2)
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
            Console.WriteLine($"\nHi! suma skaičių, mažesnių už 1000 ir kurie dalinasi iš 3 arba 5: {suma}");
            */

            // Ctrl + K, C  //komentuoti bloką
            // Ctr + K, U   //nuimti komentarus pažymėtam blokui


            ////////////// 3.b /////////////////////////////////////////
            /*
            Console.WriteLine("Pasirinkite vieną iš galimų:\n1 Kava;\n2 Arbata;\n3 Vanduo;");
            int meniu = Convert.ToInt32(Console.ReadLine());
            while (meniu < 1 || meniu > 3)
            {
                Console.WriteLine("Klaida! Įveskite tinkamą skaičių: ");
                meniu = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write($"Pasirinkote: {meniu}, t.y. ");
            switch (meniu)
            {
                case 1:
                    Console.WriteLine("kavą");
                    break;
                case 2:
                    Console.WriteLine("arbatą");
                    break;
                case 3:
                    Console.WriteLine("vandenį");
                    break;
            }
            */
            ////////////// 3.c /////////////////////////////////////////
            /*
            const int SedimuVietu = 8;
            const int VietuPrieLango = 4;
            //const string AtsakymasTaip = "taip";
            var atsakymaiYes = new List<string>() { "yes", "1", "Taip", "taip" };
            var atsakymaiNo = new List<string>() { "no", "0", "No", "ne" };
            int panaudotos_vietos = 0;
            int panaudotos_vietos_prie_lango = 0;
            do
            {
                Console.Write("Sėdėsit prie lango (taip/ne)?");
                string str = Convert.ToString(Console.ReadLine());

                if (atsakymaiYes.Contains(str))
                {
                    panaudotos_vietos_prie_lango++;
                    panaudotos_vietos++;
                }
                else if (atsakymaiNo.Contains(str))
                {
                    panaudotos_vietos++;
                }
                else
                {
                    Console.WriteLine("Neteisingai įvedėt atsakymą, pakartokit.");
                    continue;
                }
            } while (panaudotos_vietos < SedimuVietu && panaudotos_vietos_prie_lango < VietuPrieLango);
            */

            /*
            do
            {
                string input;
                do
                {

                } while (input != "yes" && input != "no");
                
                if (..) 
                {
                    //,,
                }
                //..
            } while (panaudotos_vietos < SedimuVietu || panaudotos_vietos_prie_lango < VietuPrieLango);
            */

            ////////////// 3.d /////////////////////////////////////////

            int suma = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 5 != 0)
                {
                    suma += i;
                }
                if (i > 123)
                {
                    break;
                }
            }
            Console.WriteLine($"Suma: {suma}");

            suma = 0;
            int tmp = 0;
            for (;;)
            {
                if (tmp % 5 == 0)
                {
                    continue;
                }
                if (tmp > 123)
                {
                    break;
                }
                suma += tmp;
                tmp++;
            }
            Console.WriteLine($"Suma 2: {suma}");

        }
    }
}
