using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Struct
{
    class Uzd1_Class : IPrintData
    {
        public string Surname { get; set; }
        public int someInt;
        public List<int> listTest;

        public Uzd1_Class()
        {
            Surname = "Kostruktoriuje surname";
            listTest = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                listTest.Add(i * 2);
            }
        }

        public void PrintData()
        {
            Console.WriteLine($"Klasė, surname={Surname}, someInt={someInt}");
            foreach (var item in listTest)
            {
                Console.WriteLine($"{item}");
            }
        }

    }
}
