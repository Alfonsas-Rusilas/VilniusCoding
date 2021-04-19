using HomeWork9.Lesson9;
using System;

namespace HomeWork9
{
    class Program9
    {
        static void Main(string[] args)
        {
            // ND2
            // Rasti magišką 6 (iki kito pirmadienio)
            // ========================================
            // Base - bazinė klasė
            // Protected - skirtas paveldimumui. Leidžia child matyti lauką, bet išorėje jau nesimato;
            //

            Animal animal = new Animal(5);
            animal.Live();

            Bird bird = new Bird(4, "Karpis");
            bird.Live();
            bird.Fly();

            Fish fish = new Fish(3, 44);
            fish.Swim();



            Console.WriteLine("Hello World!");
        }
    }
}
