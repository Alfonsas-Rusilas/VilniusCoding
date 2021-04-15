using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.Factory
{
    class Computer
    {
        public string Model;
        public String Type;// = { "Mobile", "Stacionary", "Other" };
        public String[] State = { "Used", "New" };
        public string Name;
        public string Processor;
        public string Ram;
        public int RamCount;
        public double Price;
        //private 

        bool IsUsed ()
        {
            return false;
        }

        bool IsNew()
        {
            return true;
        }

    }
}
