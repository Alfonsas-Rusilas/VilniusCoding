using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Error_handling.Exceptions
{
    class MySuperExceptions : Exception
    {
        public int X { get; set; }
        public int Y { get; set; }
        

        public MySuperExceptions(string str, int x2, int y2) : base(str)
        {
            X = x2;
            Y = y2;
        }
    }
}
