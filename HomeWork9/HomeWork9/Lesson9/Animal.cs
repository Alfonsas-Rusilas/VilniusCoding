using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson9
{
    class Animal
    {
        private int lifeSpan;
        protected string name;
        public string AnimalType;


        public Animal(int lifeSpan, string name, string AnimalType)
        {
            this.lifeSpan = lifeSpan;
            this.AnimalType = AnimalType;
        }

        public void Live()
        {
            //
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"Animal class > lifeSpan: {lifeSpan}");
            Console.WriteLine($"Animal class > name: {name}");
            Console.WriteLine($"Animal class > AnimalType: {AnimalType}");
        }
    }
}
