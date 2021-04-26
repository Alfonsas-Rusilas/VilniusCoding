using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Lesson12.Uzduotis_001
{
    class PrintAbleObjects
    {
        private List<IPrintable> printItems = new List<IPrintable>();

        public void AddPrintableItem(IPrintable pr)
        {
            printItems.Add(pr);
        }

        internal void PrintAll()
        {
            foreach (var item in printItems)
            {
                item.Print();
            }
        }
    }
}
