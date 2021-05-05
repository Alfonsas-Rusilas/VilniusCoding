using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Lesson16.Uzduotys
{
    class UzduotysClass1
    {
        static void Main(){

            string fname = "manoFailas.txt";

            File.WriteAllText(fname, "mano tekstas failui");
            string manoFailoTekstas = File.ReadAllText(fname);
            manoFailoTekstas += " ir dar.";

            File.AppendAllText(fname, " AppendAllText." + manoFailoTekstas);

            string manoFailoTekstas2 = File.ReadAllText(fname);
            Console.WriteLine( manoFailoTekstas2 );


            if (File.Exists(fname))
            {
                //File.Copy(fname, "NewFile" + fname);
                File.Delete(fname);
            }

            string[] strar = new string[20];
            strar = Directory.GetFiles(Directory.GetCurrentDirectory());

            for (int i = 0; i < strar.Length; i++)
            {
                Console.WriteLine($"Iteracija{i}:" + strar[i]);
            }
            



        }
    }
}
