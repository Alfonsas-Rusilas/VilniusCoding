using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.Factory
{
    class Computer
    {
        string Model;
        String[] Type = { "Mobile", "Stacionar", "Other" };
        String[] State = { "Used", "New" };
        string Name;
        string Processor;
        string Ram;
        int RamCount;
        double Price;

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
