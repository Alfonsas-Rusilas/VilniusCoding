using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Lesson8.Factory
{
    class SpaceShip
    {
        private string Name;
        private DateTime ProductionYear;
        private int SeatsNumber = 4;
        private int PilotCount;
        private string SerialNumber;
        private bool _isWorking = true;
        private string Color = "White";
        private List<DateTime> SkrydziuDatos;
        
        public SpaceShip(DateTime productionYear, string name = "Star", int pilotCount = 2, bool isWorking = true)
        {
            Name = name;
            ProductionYear = productionYear;
            SerialNumber = "123456789";
            PilotCount = pilotCount;
            _isWorking = isWorking;
            SkrydziuDatos = new List<DateTime> { productionYear }; 
        }
        
        public string GetSerialNumber()
        {
            return SerialNumber;
        }

        public int AverageTripsPerYear()
        {
            return 8;
        }

        public void AddFly(DateTime flyData)
        {
            SkrydziuDatos.Add(flyData);
        }

        public List<DateTime> GetFlys()
        {
            return SkrydziuDatos;
        }

        public bool IsWorking()
        {
            return _isWorking;
        }

        public string GetColor()
        {
            return Color;
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public string GetName()
        {
            return Name;
        }

        public DateTime GetLastFly()
        {
            return SkrydziuDatos.Max(p => p);
        }

        

    }
}
