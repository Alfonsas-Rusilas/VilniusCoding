using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Struct
{
    struct Person 
    {
        public string Name ;
        public string Surname;

        public Person(string name, string surname)
        {
            // konstruktorius kurti galima, bet tada privali inicializuoti visus kintamuosius
            Name = name;
            Surname = surname;
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }

    }
}
