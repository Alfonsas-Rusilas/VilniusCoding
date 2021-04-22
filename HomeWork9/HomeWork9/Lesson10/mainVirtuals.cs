using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson10
{
    class mainVirtuals
    {
        private static string str1 = "str1";
        private static string str2 = "str2";
        private static string str3 = "str3";
        private static string str4 = "str4";

        public static string Str1
        {
            get
            {
                Console.WriteLine($"Str1-get");
                return str1;
            }
            set
            {
                Console.WriteLine($"Str1-Set={value}");
                str1 = value;
            }
        }

        public static string Str2 { 
            get 
            {
                Console.WriteLine($"Str2-get");
                return str2;
            } 
        } 


        //private static string str33;
        public static string Str3 { 
            set {
                Console.WriteLine($"Str3-Set={value}");
                str3 = "str3"; 
            } 
        }

        public static string Str4
        {
            get
            {
                Console.WriteLine($"Str4-get");
                return str4;
            }
            private set
            {
                Console.WriteLine($"Str4-Set={value}");
                str4 = value;
            }
        }




        static void Main(string[] args)
        {

            //Student st = new Student("Pranas");
            //st.Name = "Pranas 2";


            PrintStrs();
            str1 += str1;
            str2 += str2;
            str3 += str3;
            str4 += str4;

            PrintStrs();

            PrintStrsAfter();

            Str1 = "Keičiu Str1";
            //Str2 = "Keičiu Str2";
            Str3 = "Keičiu Str3";
            Str4 = "Keičiu Str4";





            //Console.WriteLine($"str1={str1}");
            //Console.WriteLine($"str2={str2}");
            //Console.WriteLine($"str3={str3}");
            //Console.WriteLine($"str4={str4}");



            /*
            Parent parent = new Parent();
            parent.Alfa();
            parent.Beta();
            parent.Gama();

            Child ch = new Child();
            ch.Alfa();
            ch.Beta();
            ch.Gama();

            Parent par = ch;
            par.Alfa();
            par.Beta();
            par.Gama();
            */
        }

        static void PrintStrs()
        {
            Console.WriteLine($"str1={str1}");
            Console.WriteLine($"str2={str2}");
            Console.WriteLine($"str3={str3}");
            Console.WriteLine($"str4={str4}");
        }

        static void PrintStrsAfter()
        {
            Console.WriteLine("----------after--------------");
            Console.WriteLine($"str1={Str1}");
            Console.WriteLine($"str2={Str2}");
            //Console.WriteLine($"str3={Str3}");
            Console.WriteLine($"str4={Str4}");
        }
    }
}
