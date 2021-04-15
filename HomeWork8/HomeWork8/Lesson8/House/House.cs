using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.House
{
    class House
    {
        public string Name;
        public int RoomsCount;
        public string BuildDate;
        public string City;
        public string State;

        private bool IsCriticalCondition()
        {
            return true;
        }

        private bool HaveGhost()
        {
            return false;
        }

        public bool IsElectricity()
        {
            return true;
        }

        int GetRoomsCount()
        {
            return 5;
        }
    }
}
