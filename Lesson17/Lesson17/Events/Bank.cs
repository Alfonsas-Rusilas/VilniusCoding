using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Events
{
    class Bank
    {
        //public delegate void MyDelegate();
        //public delegate void OnAnyTransaction();

        //public string Name {set; get; }
        //public int Sum { set; get; }

        private string name;
        private int balance;


        public event MessageHandler OnAnyTransaction ;
        public event MessageHandler OnMoneyAdded;
        public event MessageHandler OnMoneyTransfer;


        public Bank(string name, int sum)
        {
            this.name = name;
            balance = sum;
        }

        public void AddMoney(int a)
        {
            balance += a;
            // ?.Invoke - tikrina ar netuščias OnMoneyAdded..
            OnMoneyAdded?.Invoke(" We added: " + a);
            OnAnyTransaction?.Invoke("Any transaction: added" + a);
        }

        public void TransferMoneyToCountry(string country)
        {
            OnMoneyTransfer?.Invoke("Transfered to country: " + country);
        }

        //public void AddMyEventHandler(MyDelegate handleMyEvent)
        //{
        //    MyEvent += handleMyEvent;
        //}

        //public void SendMyEvent()
        //{
        //    if (MyEvent != null)
        //    {
        //        MyEvent();
        //    }
        //}
    }
}
