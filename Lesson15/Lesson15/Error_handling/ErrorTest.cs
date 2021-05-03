using Lesson15.Error_handling.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Error_handling
{
    class ErrorTest
    {
        internal void DoSomeThingBad()
        {
            //throw new NotImplementedException();
            
            throw new MySuperExceptions("You did some bad..", 5, 8);
        }
    }
}
