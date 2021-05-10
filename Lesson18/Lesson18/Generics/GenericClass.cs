using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.Generics
{
    class GenericClass<T, TProp, TArg>
    {
        // leidžia sukurti klases nenurodant tikslaus duomenų tipo
        // pav.
        // class MyGeneric<T> {
        // }
        // T - 
        // TProp -
        // TArg - 
        // 
        // Generic klasė - stovi prie klases, ir tai kaip template klasių sukūrimui

        // 

        private T genericVariable;

        public GenericClass(T value)
        {
            genericVariable = value;
        }



    }
}
