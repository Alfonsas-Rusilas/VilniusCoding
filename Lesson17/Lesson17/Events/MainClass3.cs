using Lesson17.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Rinkiniai3
{
    class MainClass3
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Swedbank", 420);

            EmailSender emailSender = new EmailSender();

            // subscribe to event (banko)
            bank.OnAnyTransaction += emailSender.SendEmail;
            bank.OnMoneyAdded += emailSender.SendEmail;

            bank.OnMoneyTransfer += emailSender.ShowCountry;

            // arba 
            // bank.OnAnyTransaction += Console.WriteLine;


            // do action
            bank.AddMoney(210);
            bank.TransferMoneyToCountry("Lietuvon");

        }
    }
}
