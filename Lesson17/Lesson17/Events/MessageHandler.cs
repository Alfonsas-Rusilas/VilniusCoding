using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Events
{
    delegate void MessageHandler(string s);
    delegate void MoneyTransferHandler(Pocket pocket, int count);
    delegate void MoneyConversionsHandler(int money, char currency, double coeficientRate);
}
