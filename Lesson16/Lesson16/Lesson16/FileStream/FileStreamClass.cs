using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Lesson16.FileStream3
{
    class FileStreamClass
    {
        static void Main()
        {
            // FileMode - (Append, Create, CreateNew, Open, OpenOrCreate, Truncate)
            // FileAccess - (Read, ReadWrite, Write)
            // FileShare - (Inheritable, None, Read, ReadWrite, Write)
            // using - tai IDisposable interfeisas, pav. : using (StreamReader sr = File.Open("myFile.txt", FileMode.Open))
            // Būtina naudoti/gaudyti exeptions'us 
            //
            // Directory
            // CreateDirectory
            // GetCurrentDirectory
            // GetDirectories, GetFiles(String), GetFileSysteEntries()
            // EnumerateDirectories(String), EnumerateFiles(String) 
            // Move(String, String)


            FileStream fs = File.Open("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            int i = 40;
            fs.WriteByte((byte)i);
            fs.Position = 0;

            int b = fs.ReadByte();
            fs.Close();






        }
    }
}
