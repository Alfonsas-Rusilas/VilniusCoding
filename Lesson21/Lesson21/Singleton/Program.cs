using System;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cretional Patterns -
            //--------------------------------------
            //Prototype //pasidarom kopiją iš prototipo, galima dinamiškai
            //Builder // turi vieną tikslą/darbą - sukurti
            //Factory method // specialus metoda objektui pagalinti
            //Abstract Factory // turi žingsnių etapus su konkrečiais algoritmais
            //Singleton // skirtas sukurti tik vienam klasės objektui (bet ne globaliai)


            // Singleton:
            // ===============================
            //No Thread Safe Singleton.
            //Thread - Safety Singleton.
            //Thread - Safety Singleton using Double-Check Locking.
            //Thread - safe without a lock.
            //Using.NET 4's Lazy<T> type.


            //Structural Pattern
            //-------------------------
            //Adapter // vieną interfeisą konvertuoja į kitą
            //Bridge // galim kaitalioti implementaciją, žongliruoti
            //Composite //turime vienus objektus kitų objektų viduje
            //Decorator //leidžia dinamiškai pridėti funkcionalumą į objektą
            //Facade // kaip centrinis taškas, prieiti prie sistemos sub-sistemių
            //Flywight //sistema, per kurią galima pasiekti daug mažų objektų
            //Proxy //tai kaip tarpininkas kitai klasei
            //

            // Behavioral Pattern
            //Interpreter // darbas su kalbomis
            //Iterator //dažnai naudojami dirbant su krūvomis
            //Mediator //kaip proxy, tik siunčia ir gauna signalus
            //Memento - dabartinės būsenos išsaugojimas, vėliau atstatymas
            //Observer - gali matyti būsenos pasikeitimą objekte, 
            //State - pav. savo programos būsena (t.y. būsena pasidaro kaip objektas, galima keisti dinamiškai, pav. interneto puslapio būsena)
            //Strategy - strategiją įkišam į klasę, ir priklausomai nuo situacijos galim strategijas rinktis (strategija = objektas)
            //Template Method - dažniausiai turime abstrakčias funkcijas, kuria vėliau panaudojame (start, awake..)
            //Visitor - yra krūva objektų, į kurius visitorius gali įeiti ir atlikti tam tikrus darbus (objektai turi būti paruošti)
            //Command - enkapsuliuojam funkcionalumą į objektą


            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2 && singleton1 != null)
            {
                Console.WriteLine("Viskas gerai!");
            } else
            {
                Console.WriteLine("Blogai, skirtingi objektai arba tušti");
            }



            //Console.WriteLine("Hello World!");
        }
    }
}
