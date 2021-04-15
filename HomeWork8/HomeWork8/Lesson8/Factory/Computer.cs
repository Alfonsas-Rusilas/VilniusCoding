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
        public String State;
        public string Name;
        public string Processor;
        public string RamModel;
        public int RamCount;
        public double Price;
        public DateTime ProductionData;
        //private 

        public Computer(string state = "New", int ramCount = 8, string model = "Lenovo")
        {
            State = state;
            RamCount = ramCount;
            Model = model;
        }

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
