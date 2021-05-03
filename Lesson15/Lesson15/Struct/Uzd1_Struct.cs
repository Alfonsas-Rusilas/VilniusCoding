using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Struct
{
    struct Uzd1_Struct : IPrintData
    {
        public int myInt;
        public string Name;
        public List<int> listTest;
        public bool IsDataReady { set; get; }

        public Uzd1_Struct(string name)
        {
            myInt = 123;
            this.Name = name;
            listTest = new List<int>();
            IsDataReady = false;
        }

        public void PrintData()
        {
            Console.WriteLine($"Struktūra: myInt={myInt}, Name={Name}");
            foreach (var item in listTest)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
