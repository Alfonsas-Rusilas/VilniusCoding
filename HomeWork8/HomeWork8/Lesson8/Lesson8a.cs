using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork8.Lesson8.Factory;

namespace HomeWork8
{
    class Lesson8a
    {
        static void Main()
        {
            //
            // Klasė - tai aprašas (kokie duomenys, ir kaip būsimas objektas veiks).
            // Sudaro: duomenys (ar kintamieji - fields, variables);
            // Sudaro: methods, functions
            // Sudaro: properties (savybės)
            // Sudaro: members (nariai)
            ////////// Lesson 8.a

            SpaceShip ship = new SpaceShip(new DateTime(2021, 04, 17), "MoonMars", 1);

            Console.WriteLine($"Erdvėlaivio vardas: {ship.GetName()}");
            Console.WriteLine($"Erdvėlaivio spalva: {ship.GetColor()}");
            Console.WriteLine($"Erdvėlaivio skrendantis? - {ship.IsWorking()}");
            ship.SetColor("Pilkas");
            Console.WriteLine($"Erdvėlaivio spalva perdažius: {ship.GetColor()}");
            ship.AddFly(new DateTime(2021, 04, 15));
            PrintValues(ship.GetFlys(), "Visi skrydžiai: ");
            Console.WriteLine($"Erdvėlaivio paskutinis skrydis: {ship.GetLastFly()}");
           
        }


        static void PrintValues(List<string> myList, string message = "")
        {
            Console.Write(message);
            foreach (string i in myList)
                Console.Write($"   {i}");
            Console.WriteLine();
        }

        static void PrintValues(List<DateTime> myList, string message = "")
        {
            Console.Write(message);
            foreach (DateTime d in myList)
                Console.Write($"   {d}");
            Console.WriteLine();
        }


    }
}
