using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.Extension_methods
{
    static class StringExtensiond
    {

        public static string[] CutToWords(this string data)
        {
            // this - tai bus:
            // string str;
            // str.CutToWords

            return new string[5];
        }

        public static string CutToWordsStr(this string data)
        {
            // this - tai bus:
            // string str;
            // str.CutToWords

            return data + " CutToWordsStr!";
        }

    }
}
