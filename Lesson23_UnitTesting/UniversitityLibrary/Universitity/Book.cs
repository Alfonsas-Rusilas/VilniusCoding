using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitityLibrary.Universitity
{
    public class Book
    {
        // internal - matomumas tik projekto viduje, pagal nutylėjimą

        public int Id { get; set; }

        public Book(int id)
        {
            Id = id;
        }

    }
}
