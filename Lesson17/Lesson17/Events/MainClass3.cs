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
            Pocket myPocket = new Pocket("Antanas", 20);
            
            EmailSender emailSender = new EmailSender();
            FileLogger fileLogger = new FileLogger("bankLog.txt");

            // subscribe to event (banko)
            bank.OnAnyTransaction += emailSender.HandlePrintTransaction;
            bank.OnAnyTransaction += fileLogger.HandleWriteTransaction;

            bank.OnMoneyConversion += fileLogger.HandleWriteConversion;
            bank.OnMoneyAdded += fileLogger.HandlePrintAddMoney;
            bank.OnMoneyTransfer += fileLogger.HandlePrintMoneyTransfered;


            // do action
            bank.AddMoney(210);
            bank.TransferMoney(myPocket, 120);
            bank.ConvertToCurrency(100, '$', 1.2436f);
            Console.ReadKey();
        }
    }
}
