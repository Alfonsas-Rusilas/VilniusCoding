using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Events
{
    class EmailSender
    {

        public void SendEmail(string s)
        {
            Console.WriteLine("Emailsender event trigered! " + s);
        }

        public void HandlePrintTransaction(string s)
        {
            Console.WriteLine("HandlePrintTransaction event trigered! " + s);
        }

    }
}
