using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Events
{
    class Pocket
    {
        private int balance;
        private string name;

        public Pocket(string name, int sum)
        {
            balance = sum;
            this.name = name;
        }

        public void AddMoney(int money)
        {
            balance += money;
        }

        public string GetName()
        {
            return name;
        }

    }
}
