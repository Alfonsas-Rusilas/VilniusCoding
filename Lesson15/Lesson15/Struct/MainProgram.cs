using Lesson15.Struct;
using System;

namespace Lesson15
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // struct
            // struct - nepalaiko paveldimumo
            // struct gali turėti funkciją
            // struct perduodant kaip funkcijos parametrą, atiduodama jos kopija (value data type)
            // struct - reikia vengti daryti su reference data type objektais (t.y. masyvais, Lits's, class)
            // DateTime - yra struct
            // Enkapsuliacija nėra būtina, nes joje tik duomenys

            Console.WriteLine("------------------------- Konstruktorius ----------------");
            Uzd1_Class clas = new Uzd1_Class();
            clas.PrintData();

            Uzd1_Struct strc = new Uzd1_Struct("Struktūra");
            for (int i = 0; i < 2; i++)
            {
                strc.listTest.Add(i + 2);
            }
            strc.PrintData();

            DoStructMethod(strc);
            DoClassMethod(clas);

            Console.WriteLine("------------------------- Pakeitus (per funkciją) -------------");

            clas.PrintData();
            strc.PrintData();
        }

        static void DoStructMethod(Uzd1_Struct str)
        {
            str.myInt = 444;
            str.Name = "444";
            str.listTest[0] = 444;
        }

        static void DoClassMethod(Uzd1_Class cls)
        {
            cls.someInt = 888;
            cls.Surname = "888";
            cls.listTest[0] = 888;
        }
    }
}
