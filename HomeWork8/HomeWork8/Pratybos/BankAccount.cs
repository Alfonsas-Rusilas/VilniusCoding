using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Pratybos
{
    class BankAccount
    {
        private string AccountOwner;
        private string AccountNumber;
        private string BankName;
        private double Balance;

        public BankAccount(string AccountOwner, string account, string BankName, double balance = 0)
        {
            this.AccountOwner = AccountOwner;
            AccountNumber = account;
            this.BankName = BankName;
            Balance = balance;
        }

        public void AddToBalance(double val)
        {
            Balance += val; 
        }

        public void RemoveFromBalance(double val)
        {
            Balance -= val;
        }
        public double GetBalance()
        {
            return Balance;
        }

    }
}
