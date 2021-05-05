using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    class Main14
    {
        static void Main()
        {
            // klasės struktūros:
            //====================
            //public
            //internal
            //protected internal
            //protected
            //private protected
            //private
            //
            //static 
            //not static
            //Console.WriteLine("Testas");

            Human boss = new Human(64, "Vytautas");
            Company company = new Company(boss, "Lego Company");

            company.OfficePet = new Dog(10, "Brisius");

            company.HireWorker(new Worker(40, "Valytojas Jonas", 460));
            company.HireWorker(new Worker(45, "Programuotojas Žilvinas", 2500));

            company.AddClient(new Client(60, "Kęstas"));
            company.AddClient(new Client(22, "Onutė"));

            company.PrintInfo();

            Console.ReadKey();




        }
    }
}
