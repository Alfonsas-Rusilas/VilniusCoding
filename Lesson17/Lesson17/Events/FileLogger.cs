using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading.Tasks;

namespace Lesson17.Events
{
    class FileLogger
    {
        private string fname;
        public FileLogger(string file)
        {
            fname = file;
            using StreamWriter somefile = new(file, append: true);
            somefile.WriteLine("================ Starting = " + DateTime.Now + "===============") ;
        }

        public void HandleWriteTransaction(string money)
        {
            //Console.WriteLine("HandleWriteTransaction: " + money);
            using StreamWriter file = new(fname, append: true);
            file.WriteLine(DateTime.Now + " Any transaction: " + money);
        }

        public void HandleWriteConversion(int money, char Cur, double rateCoeficient)
        {
            double conv = money * rateCoeficient;
            using StreamWriter file = new(fname, append: true);
            file.WriteLine($"{DateTime.Now} Conversion: {money}, {Cur}, {rateCoeficient}");
        }

        public void HandlePrintTransaction(string money)
        {
            using StreamWriter file = new(fname, append: true);
            file.WriteLine($"{DateTime.Now} HandlePrintTransaction: {money}");
        }

        internal void HandlePrintAddMoney(string money)
        {
            using StreamWriter file = new(fname, append: true);
            file.WriteLine($"{DateTime.Now} HandlePrintAddMoney: {money}");
        }

        public void HandlePrintMoneyTransfered(Pocket pocket, int money)
        {
            using StreamWriter file = new(fname, append: true);
            file.WriteLine($"{DateTime.Now} HandlePrintMoneyTransfered to Pocket: {pocket.GetName()} < {money}");
        }

    }
}
