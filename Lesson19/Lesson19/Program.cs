using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 0, Name = "Kestas", Age = 25, AvarageMark = 6.1, IsGettingTuition = true },
                new Student() { Id = 1, Name = "Ona", Age = 25, AvarageMark = 9.4, IsGettingTuition = true },
                new Student() { Id = 2, Name = "Petras", Age = 21, AvarageMark = 5.3, IsGettingTuition = true },
                new Student() { Id = 3, Name = "Gabija", Age = 21, AvarageMark = 8.2, IsGettingTuition = false },
                new Student() { Id = 4, Name = "Jonas", Age = 17, AvarageMark = 4.5, IsGettingTuition = true },
                new Student() { Id = 5, Name = "Biata", Age = 15, AvarageMark = 9.2, IsGettingTuition = false },
                new Student() { Id = 6, Name = "Kęstas", Age = 25, AvarageMark = 6.1, IsGettingTuition = true },
                new Student() { Id = 7, Name = "Rimantas", Age = 25, AvarageMark = 9.4, IsGettingTuition = false },
                new Student() { Id = 8, Name = "Hansas", Age = 21, AvarageMark = 5.3, IsGettingTuition = true },
                new Student() { Id = 9, Name = "Jorukas", Age = 21, AvarageMark = 8.2, IsGettingTuition = false },
                new Student() { Id = 10, Name = "Rimantas", Age = 17, AvarageMark = 4.5, IsGettingTuition = true },
                new Student() { Id = 11, Name = "Joana", Age = 15, AvarageMark = 9.2, IsGettingTuition = false }
            };


            var filterResNames = from p in students
                            select p.Name;

            //foreach (var item in filterResNames)
            //{
            //    Console.WriteLine("" + item.ToString());
            //}
            //Console.WriteLine("=================================================");


            var filterRes = from p in students
                            where p.Age > 20 && p.Age < 35
                            select p;

            //foreach (var item in filterRes)
            //{
            //    Console.WriteLine("" + item.Name + "; " + item.Age);
            //}
            //Console.WriteLine("=================================================");

            var filterRes2 = from p in students
                            where p.AvarageMark > 5 && p.IsGettingTuition == false
                            orderby p.Age
                            select p;


            var filterOver20 = from p in students
                             where p.Age > 20
                             orderby p.Name
                             select new { p.Id, Name = p.Name };

            var filterOver3 = from p in students
                              where p.IsGettingTuition == true
                              select new { Name = p.Name, GoodStudent = (p.AvarageMark>8)?(true):(false) };

            var filterOver4 = from p in students
                              where p.IsGettingTuition == true
                              select new { Name = p.Name, GoodStudent = (p.AvarageMark > 8)};


            //foreach (var item in filterOver20)
            //{
            //    Console.WriteLine("" + item.ToString() + "   ; GetHashCode=" + item.GetHashCode());
            //}
            //Console.WriteLine("=================================================");


            //foreach (var item in filterOver4)
            //{
            //    Console.WriteLine("" + item.ToString() + "   ; GetHashCode=" + item.GetHashCode());
            //}
            //Console.WriteLine("=================================================");


            var filterOver5 = from p in students
                              where p.Name.Length > 5
                              select new { p.Id, p.Name, Status = (p.AvarageMark < 5) ? ("Bad") : (p.AvarageMark > 8) ? ("Good") : ("Vidurys") }
                              into p2
                              group p2 by p2.Status;


            foreach (var item in filterOver5)
            {
                Console.WriteLine("Group : " + item.Key);
                foreach (var s in item)
                    Console.WriteLine(s.Name + "; " + s.ToString());
            }





        }


        public static void PrintSet(IEnumerable<Student> set)
        {
            foreach (var item in set)
            {
                Console.WriteLine("" + item.ToString() + "   ; GetHashCode=" + item.GetHashCode());
            }
            Console.WriteLine("=================================================");
        }

    }
}
