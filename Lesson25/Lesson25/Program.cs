using System;
using System.Threading.Tasks;

namespace Lesson25
{
    class Program
    {
        static void Main(string[] args)
        {
            // All Access Modifiers
            // --------------------------
            // public, private, protected, internal, protected internal, private potected
            // public - mato visi
            // private - tik klasės vidus mato
            // protected - pati klasė ir jos paveldėtojos
            // internal - visi mato, bet tik bibliotekos (dll failo) viduje
            // protected internal - abiejų suma
            // private potected - mato tik vaikai tame pačiame modulyje
            //
            // class access modifiers   // pagal nutylėjimą internal
            // internal
            // public
            //
            // [internal, public ] class {
            //      
            // }
            //
            //
            // Concurency -
            // --------------------------
            // Parallel (daug branduolių) and
            // Concurent (kai vienam branduolyje keletas užduočių
            // 
            // pav. private static async void OnRequestDownloadAsync() {  var response = await get "www.yuotube.com"     }
            // pav. private static async Task<int> OnRequestDownloadAsync() {  var response = await get "www.yuotube.com"; return 5     }
            //
            //
            // Parallel - naudojama kai turima daug branduolių
            // Task task = Task.Run( () => PrintInfo("Task") );
            // PrintInfo("Application")
            // task.Wait();
            // ...----....
            //  static void PrintInfo(string msg) { WriteLine({0} Thread ID, msg, Thread.CurrentThread.ManagedThreadId)); } 
            //
            //
            //
            //
            // Concurency data lock
            // --------------------------
            // lock(syncObject) { counter++; } //pasitikrina branduolys, ar objektas neužrakintas kito branduolio, ir palaukia
            // ConcurrentDictionary<TKey,Tvalue>    // jau turi branduoliams pritaikytus metodus
            // ConcurrentQuene<T>
            // SynchronizedCollection<T>
            //
            //
            // dynamic kintamieji   // galima panaudoti konvertuojant iš kitos kalbos
            // --------------------------
            // dynamic test = 123
            // test = "bar"
            // test = 2 / 5;
            // test = new Enemy();
            //
            //
            // Indexer
            // > panaudoja get {...} ir set {...}, 
            //
            //
            // Reflection   // klasių analizė, properčių gavimas, ir dinamiškas jų panaudojimas
            //  



            //int result = await DoStuffAsync();
            
        }

        //static async Task<int> DoStuffAsync()
        //{
        //    return 5;
        //}


    }
}
