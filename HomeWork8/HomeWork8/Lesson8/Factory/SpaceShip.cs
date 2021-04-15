using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.Factory
{
    class SpaceShip
    {
        public string Name;
        public int Year;
        //string[] Planets = { "Moon", "Mars" }; 
        
        private int AverageTripsPerYear()
        {
            return 8;
        }


        bool IsWorking()
        {
            return true;
        }

    }
}
