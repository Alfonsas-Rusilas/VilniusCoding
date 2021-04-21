using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson9
{
    class Bird : Animal
    {
        // public Child(....) : base (nr) 
        // kad pasiekti tėvinės klasės protecded kintamąjį, galime: base.name = "zzzzTTT" 
        //private int lifeSpan;
        //protected string name;
        //public string AnimalType;

        private string featherColor;
        private bool CanFly;
        protected bool IsWaterBird;
        public bool IsMigrating;

        public Bird(int lifeSpan, string featherColor, bool CanFly, string name, string AnimalType, bool IsWaterBird, bool IsMigrating) : base(lifeSpan, name, AnimalType)
        {
            this.featherColor = featherColor;
            this.IsWaterBird = IsWaterBird;
            this.CanFly = CanFly;
            this.IsMigrating = IsMigrating;
        }

        public void Fly()
        {
            //
        }

        public void PrintBird()
        {
            Console.WriteLine($"Bird class > featherColor: {featherColor}");
            Console.WriteLine($"Bird class > CanFly: {CanFly}");
            Console.WriteLine($"Bird class > IsWaterBird: {IsWaterBird}");
            Console.WriteLine($"Bird class > IsMigrating: {IsMigrating}");
            Console.WriteLine($"Bird class > Base.name: {base.name}");
            Console.WriteLine($"Bird class > Base.AnimalType: {base.AnimalType}");
        }

    }
}
