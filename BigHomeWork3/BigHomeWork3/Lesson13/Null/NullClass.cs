using BigHomeWork3.GameSample.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13.Null
{
    class NullClass
    {
        public static void Main()
        {
            // int s = null;   // error!

            int? nulable_int = null; // tai įpakuotas skaičius į objektą, ir šis objektas gali nurodyti null ar bet kokią kitą reikšmę

            Hero h = new Hero("name",1,5);
            h = null;

            if (h == null)
            {
                // tuščias objektas, veiksmų negalime atlikti!
            }


        }
    }

}
