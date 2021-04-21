using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson9
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(25, "Strazdas", "Paukštis");
            Bird bird = new Bird(2, "pink", true, "Žvirblis", "Paukštis", false, false);

            Console.WriteLine($"Animal class: {animal.AnimalType}");

            Console.WriteLine($"Bird class: {bird.AnimalType}");

            animal.PrintAnimal();

            bird.PrintBird();

        }

        static void PrintInfo(string str) 
        {
            Console.WriteLine("");
        } 
    }
}
