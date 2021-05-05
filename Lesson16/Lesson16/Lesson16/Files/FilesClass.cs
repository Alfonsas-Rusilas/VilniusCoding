using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Lesson16.Files
{
    class FilesClass
    {
        static void Main(string[] args)
        {
            // File I/O - static klasė (unikali ir globali), using System.IO
            // FileInfo - objektas, konkrečiam darbui su failu
            // FileStream - objektas detaliam darbui su failu (jau su srautu); 
            // 
            // Directory - statinė klasė
            // DirectoryInfo - objektas darbui su konkrečiu katalogu
            //
            // Path
            // File.WriteAllText
            //
            // File.WriteAllText
            // File.ReadAllText("mano.txt")
            // File.Create()
            // File.Delete();
            // File.Exists()
            // File.Copy();
            // File.Move()
            // 


            // Releative path (naudokite pagal nutylėjimą):
            //-------------------------------
            File.WriteAllText("testas.txt", "Įrašomas string į failą");
            File.WriteAllText("../testas.txt", "Eisiu atgal, ir įrašomas string į failą");
            File.WriteAllText("logs/testas.txt", "Įrašomas string į failą");


            // Full path:
            //-------------------------------
            File.WriteAllText("C:\\temp\\testas.txt", "Įrašomas string į failą");
            // yra Pro character - '@', tai yra viskas ignoruojama iki kabučių:
            File.WriteAllText(@"C:\temp\testas2.txt", "Įrašomas string į failą");
            // galima naudoti abu : @ ir $
            int x = 4;
            string data = $"Bla bla {x}";
            string data2 = $@"Testas testas {x} ir dar testas";
            Console.WriteLine(data2);


        }
    }
}
