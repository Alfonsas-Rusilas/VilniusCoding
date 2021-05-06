using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Events
{
    class EmailSender
    {


        public EmailSender()
        {
            //
        }

        public void SendEmail(string s)
        {
            Console.WriteLine("Emailsender event trigered! " + s);
        }

        public void ShowCountry(string s)
        {
            Console.WriteLine("Country= " + s);
        }
    }
}
