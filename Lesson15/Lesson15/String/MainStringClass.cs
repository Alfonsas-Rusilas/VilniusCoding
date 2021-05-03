using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.String
{
    class MainStringClass
    {
        public static void Main()
        {
            // string - funkcijose perduodama kopijos
            // string - yra System.String
            // Jei dirbame su dideliais tekstais, naudojama StringBuilder
            // string - tai klasė

            string test1 = "abc";
            string test2 = "123";

            test1 = test1 + "!"; // bus sukurta test1 kopija, ir pridėtas simbolis


        }
    }
}
