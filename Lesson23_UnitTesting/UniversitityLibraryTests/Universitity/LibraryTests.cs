using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitityLibrary;
using UniversitityLibrary.Universitity;

namespace UniversitityLibraryTests.Universitity
{
    [TestClass]
    public class LibraryTests
    {
        // TDD, Unit testing
        //=========================================================================
        //Waterfall: senas būdas daryti viską iš karto, rezultatas pasimato tik gale 
        //Agilė: naudoja framework - Scrum, Kanban, XP

        //Įrankiai: 
        //JIRA (A. must)
        //Azure DevOps (A. must)
        //Trello (nemokama)
        //Asana
        //Basecamp
        //Bugzilla

        //Reikalavimų atitikimas:
        //- Funkciniai testai //Modulių testai, Integraciniai, GUI
        //- NeFunkciniai testai (preformance, apkrovos, scalability, independance, tetability...)
        //Veikia be klaidų
        //Saugumas

        //Modulių testai (Unit testai)
        //- Kiekviena klasės funkcija ir jos visi scenarijai testuojami individualiai
        //- Turi būti: izoliuoti, lengvai paleidžiami, lengvai rašomi, greiti.
        //======================================

        //Assert.AreEqual	// ar lygios reikšmės (pav. 2-iejų struktūrų)
        //Assert.AreSame 	// ar tai tas pats objektas atmintyje
        //Assert.IsTrue
        //Assert.IsNull
        //Assert.Fail 	


        [TestMethod]
        public void AddBook_AddOneBook_BookCountIncred()
        {
            //Arrange
            IBookAction library = new Library();
            
            // Act
            Book book = new Book(0);
            library.AddBook(book);

            // Assert
            Assert.AreEqual(1, library.BookCount, "I was looking for 1 book");
        }


        [TestMethod]
        public void AddBook_AddFiveBookThenRemoveOne_BookCountReducedByOne()
        {
            //Arrange
            IBookAction library = new Library();

            // Act
            library.AddBook(new Book(1));
            library.AddBook(new Book(2));
            library.AddBook(new Book(3));
            library.AddBook(new Book(4));
            library.AddBook(new Book(5));
            library.RemoveBook(3);
            
            //Assert
            Assert.AreEqual(4, library.BookCount, "4 should by");
        }

        [TestMethod]
        public void GetBook_AddFiveBookThenGetOne_CorrectBookReceived()
        {
            //Arrange
            IBookAction library = new Library();

            // Act
            library.RemoveAllBooks();
            library.AddBook(new Book(1));
            library.AddBook(new Book(2));
            Book book = new Book(3);
            library.AddBook(book);
            library.AddBook(new Book(4));
            library.AddBook(new Book(5));

            //Assert
            Assert.AreEqual(book, library.GetBook(2), "Is not same objects");
        }


    }
}
