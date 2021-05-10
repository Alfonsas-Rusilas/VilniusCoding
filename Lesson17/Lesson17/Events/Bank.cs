using Lesson17.Rinkiniai3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Events
{
    

    class Bank
    {
        private string name;
        private int balance;

        public event MessageHandler OnAnyTransaction ;
        public event MessageHandler OnMoneyAdded;
        public event MoneyTransferHandler OnMoneyTransfer;
        public event MoneyConversionsHandler OnMoneyConversion;

        public Bank(string name, int sum)
        {
            this.name = name;
            balance = sum;
        }

        public void AddMoney(int a)
        {
            balance += a;
            OnMoneyAdded?.Invoke("Bank->AddMoney, added: " + a);
            OnAnyTransaction?.Invoke("Any transaction: added: " + a);
        }

        public void TransferMoney(Pocket myPocket, int money)
        {
            balance -= money;
            myPocket.AddMoney(money);
            OnMoneyTransfer?.Invoke(myPocket, money);
            OnAnyTransaction?.Invoke("TransferMoney: " + money);
        }

        public void ConvertToCurrency(int money, char Cur, double rate)
        {
            OnMoneyConversion(money, Cur, rate);
            OnAnyTransaction?.Invoke("ConvertToCurrency: " + money);
        }

    }
}
