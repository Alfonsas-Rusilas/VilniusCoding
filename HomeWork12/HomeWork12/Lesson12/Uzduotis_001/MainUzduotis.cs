using HomeWork12.Lesson12.Uzduotis_001.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Lesson12.Uzduotis_001
{
    class MainUzduotis
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Ghost ghost = new Ghost();
            Hero hero = new Hero();
            House house = new House();
            Sun sun = new Sun();

            PrintAbleObjects printObj = new PrintAbleObjects();
            printObj.AddPrintableItem(dog);
            printObj.AddPrintableItem(ghost);
            printObj.AddPrintableItem(hero);
            printObj.AddPrintableItem(house);
            printObj.AddPrintableItem(sun);
            printObj.PrintAll();





            //List<IPrintable> printAble = new List<IPrintable>();
            //IRenderable[] renderAble = new IRenderable[1];

            //var tipas = typeof(IPrintable);
            //foreach (var m in tipas.GetMethods())
            //{
            //    Console.WriteLine(m.Name);
            //}

        }
    }
}
