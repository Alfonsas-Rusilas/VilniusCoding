using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitityLibrary.Universitity;

namespace UniversitityLibrary
{
    public interface IBookAction
    {


        int BookCount { get; }

        void AddBook(Book book);

        void RemoveBook(int BookId);

        Book GetBook(int BookId);

        void RemoveAllBooks();
    }
}
