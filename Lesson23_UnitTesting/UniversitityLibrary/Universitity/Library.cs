using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitityLibrary.Universitity
{
    public class Library : IBookAction
    {

        private List<Book> books = new List<Book>();


        public int BookCount { get { return books.Count; } }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(int bookId)
        {
            books.RemoveAll(b => b.Id == bookId);
        }


        public Book GetBook(int bookId)
        {
            return books.Find(b => b.Id == bookId);
        }

        public void RemoveAllBooks()
        {
            books.Clear();
        }
    }
}
