using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.Factory
{
    class Table
    {
        string Name;
        string[] Material = { "Metal", "Wood", "Glass" };
        string Color;
        int Width;
        int Length;
        int ID;
        double Price;
        double Discount = 0.5;
        string warehouse;

        bool IsNew()
        {
            return true;
        }

        bool IsBroken()
        {
            return false;
        }
    }
}
