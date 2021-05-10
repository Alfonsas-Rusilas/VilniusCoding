using Lesson18.Uzduotis1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.LINQ
{
    class MainLinq
    {
        static void Main()
        {
            // LINQ - užklausų sintaksė gauti duomenims iš įvairiausių šaltinių.
            // Turi panašumą į SQL, tai yra atskira skriptavimo kalba
            // Galima dirbti su: Ado.net, 
            // Naudoja interfeisus: IEnumerable ir IQueryable
            // 
            // Using System.Linq

            //IList<string> stringList = new

            List<string> stringList = new List<string>()
            {
                "aaaaaa",
                "bbbbbbb",
                "cccc"
            };

            // Linq Query
            var result = from s in stringList
                         where s.Contains("Tutor")
                         select s;

            // Linq Method
            var result2 = stringList.Where(s => s.Contains("Tutor")); 

            //Linq Query sintaksė:
            IEnumerable<string> result5 = from s in stringList
                                          where s.Contains("Tutor")
                                          select s;


            // rezultatus į List:
            List<string> result7 = (from s in stringList
                         where s.Contains("Tutor")
                         select s).ToList();
            
            // rezultatus į Array:
            string[] result8 = (from s in stringList
                                where s.Contains("Tutor")
                                select s).ToArray();





            List<Student> students = new List<Student>()
            {
                new Student() { Id = 0, Name = "Kestas", Age = 30, AvarageMark = 6.1, IsGettingTuition = true },
                new Student() { Id = 1, Name = "Ona", Age = 25, AvarageMark = 9.4, IsGettingTuition = false },
                new Student() { Id = 2, Name = "Petras", Age = 21, AvarageMark = 5.3, IsGettingTuition = true },
                new Student() { Id = 3, Name = "Gabija", Age = 19, AvarageMark = 8.2, IsGettingTuition = false },
                new Student() { Id = 4, Name = "Jonas", Age = 17, AvarageMark = 4.5, IsGettingTuition = true },
                new Student() { Id = 5, Name = "Biata", Age = 15, AvarageMark = 9.2, IsGettingTuition = false }
            };

            var filteredRes = from s in students
                              where s.Age > 12
                              where s.Age < 20
                              select s;
            //////////////////////////////////////////////////////////////////////////////////

            var CanDrink = from s in students
                              where s.Age >= 21
                              orderby s.Name
                              select s;

            var ValstybesRemiami = from s in students
                                 where s.AvarageMark > 8
                                 where s.IsGettingTuition 
                                 select s;

            var MultiStudens = from s in students
                                 where s.AvarageMark < 4
                                 where s.Name.Length <= 8
                                 select s;

            var VidurkisIrParamaStudentaiNames = from s in students
                                 where s.IsGettingTuition
                                 where s.AvarageMark > 4
                                 select s.Name;

            var StudentsId = from s in students
                              where s.Name.Length <= 8
                              where s.AvarageMark < 4
                              orderby s.Name
                              select s.Name;

            //Student newStudent;// = ;
            var NewStudent = from s in students
                             where s.Name.Length <= 8
                             where s.AvarageMark < 4
                             //orderby s.Name
                             select new Student() { Id = s.Id++, Name = s.Name, Age = 30, AvarageMark = 6.1, IsGettingTuition = true};

        }
    }
}
