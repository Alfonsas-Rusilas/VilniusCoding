using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Pratybos
{
    class Product
    {
        private string ID;
        private string Name;
        private string ProductType;
        private string ProductSubType;
        private double Price;
        private int Likutis;
        private string Vienetai;
        private bool Kondicija;

        public Product(string id = "12345678", string name = "Aukšč. rūšies miltai", string prodType = "Maistas", string prodSubType = "Miltai")
        {
            SetID(id);
            SetName(name);
            SetProductType(prodType);
            SetProductSubType(prodSubType);
            SetLikutis(100);
            SetPrice(1.85);
            Kondicija = true;
            Vienetai = "kg";
        }

        public void Parduok(int parduodamas_kiekis)
        {
            if (Likutis >= parduodamas_kiekis)
            {
                SetLikutis(Likutis - parduodamas_kiekis);
            }
                
        }

        public void SetID(string id)
        {
            ID = id;
        }
        public string GetID()
        {
            return ID;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetProductType(string type)
        {
            ProductType = type;
        }

        public string GetProductType()
        {
            return ProductType;
        }
        public void SetProductSubType(string type)
        {
            ProductSubType = type;
        }
        public string GetProductSubType()
        {
            return ProductSubType;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public double GetPrice()
        {
            return Price;
        }
        public void SetLikutis(int likutis)
        {
            Likutis = likutis;
        }
        public double GetLikutis()
        {
            return Likutis;
        }

    }
}
