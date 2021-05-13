using Lesson18.Uzduotis1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.UzduotisRusiavimas
{
    class OrderByClass
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 0, Name = "Kestas", Age = 25, AvarageMark = 6.1, IsGettingTuition = true },
                new Student() { Id = 1, Name = "Ona", Age = 25, AvarageMark = 9.4, IsGettingTuition = false },
                new Student() { Id = 2, Name = "Petras", Age = 21, AvarageMark = 5.3, IsGettingTuition = true },
                new Student() { Id = 3, Name = "Gabija", Age = 21, AvarageMark = 8.2, IsGettingTuition = false },
                new Student() { Id = 4, Name = "Jonas", Age = 17, AvarageMark = 4.5, IsGettingTuition = true },
                new Student() { Id = 5, Name = "Biata", Age = 15, AvarageMark = 9.2, IsGettingTuition = false }
            };

            
            var filteredRes = from p in students
                              orderby p.AvarageMark 
                              select p;

            var filteredRes2 = students.OrderBy(p => p.AvarageMark);

            var filteredResAge = from p in students
                              orderby p.Age descending
                              select p;

            var filteredResAge2 = students.OrderByDescending(p => p.AvarageMark);

            var filteredResAgeAndAvr = from p in students
                                 orderby p.Age descending, p.AvarageMark descending
                                 select p;

            var filteredResAgeAndAvr2 = students.OrderByDescending(p => p.Age).ThenByDescending(p => p.AvarageMark);





            var data = from s in students
                              orderby s.Age, s.AvarageMark descending
                              select s;


            // jei rūšiuojame objektus, pakeitėm Student klasė
            var data2 = from s in students
                       orderby s
                       select s;


            //foreach (var item in data2)
            //{
            //    Console.WriteLine(item.Name + "; age: " + item.Age);
            //}


            var filteredResAvgAge = from p in students
                                    group p by p.Age; 

            //foreach (var item in filteredResAvgAge)
            //{
            //    Console.WriteLine("Key: " + item.Key);
            //    foreach (Student s in item) 
            //        Console.WriteLine("Student Name: {0}", s.Name);
            //}

            ///// 

            var filteredIsTuition = from p in students
                                    group p by p.IsGettingTuition;

            //foreach (var item in filteredIsTuition)
            //{
            //    Console.WriteLine("Key: " + item.Key);
            //    foreach (Student s in item)
            //        Console.WriteLine("Student Name: {0}", s.Name);
            //}


            var filteredRes10 = from p in students
                                group p by "Iki " + ((p.Age / 10) + 1) + "0";

            foreach (var item in filteredRes10)
            //    foreach (IGrouping<int, Student> item in filteredRes10)
            {
                Console.WriteLine("Key dešimtmetis: " + item.Key);
                foreach (Student s in item)
                    Console.WriteLine("Student Name: {0}", s.Name);
            }


            var filteredRes10ex = from p in students
                                  group p by new { ageMilenium = p.Age / 10, isGettingT = p.IsGettingTuition } ;


            foreach (var item in filteredRes10ex)
            //    foreach (IGrouping<int, Student> item in filteredRes10)
            {
                Console.WriteLine("Key dešimtmetis: " + item.Key);
                foreach (Student s in item)
                    Console.WriteLine("Student Name: {0}", s.Name);
            }

        }
    }
}
