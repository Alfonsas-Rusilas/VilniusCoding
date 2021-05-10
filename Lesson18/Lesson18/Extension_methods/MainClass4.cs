using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson18.Extension_methods;

namespace Lesson18.Extension_methods
{
    class MainClass4
    {
        static void Main()
        {
            //StringHelper.ChangeString("");

            //var word = StringHelper.CutToWords4("");

            string text = " TESTAS ";

            //string[] result = text.CutToWords();

            string result4 = text.CutToWordsStr();
            Console.WriteLine( result4 );


        }
    }
}
