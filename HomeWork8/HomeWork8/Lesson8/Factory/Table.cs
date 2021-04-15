using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.Factory
{
    class Table
    {
        public string Name;
        public string Color;
        public int Width;
        public int Length;
        private int ID;
        private string CreatedBy;
        public double Price;
        private double Discount = 0.5;
        public string Warehouse;

        public Table()
        {
            //
        }
        

        public bool IsNew()
        {
            return true;
        }

        public string GetMaterial()
        {
            return "Wood";
        }

        public bool IsBroken()
        {
            return false;
        }
    }
}
