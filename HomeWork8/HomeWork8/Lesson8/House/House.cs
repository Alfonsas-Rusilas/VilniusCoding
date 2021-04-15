using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.House
{
    class House
    {
        public string Owner;
        public int RoomsCount;
        public string BuildDate;
        public string City;
        public string State;
        public string Street;

        public House(int rooms = 5, string buildDate = "2021-04-14")
        {
            RoomsCount = rooms;
            BuildDate = buildDate;
        }

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

        public int GetRoomsCount()
        {
            return 5;
        }
    }
}
