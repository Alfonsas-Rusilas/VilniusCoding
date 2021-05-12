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
            //
            // All - ar visi atitinka sąlygas, Any - ar bent vienas, Contain - 
            // Aggregate - 
            // OfType - paima tik nurodyto tipo narius, pav. var strRes = mixedList.OfType<>() //paima tik string tipo
            // Single - kai elementas egzistuoja tik vienas, tai jį grąžina
            // FirstOrDefault - praverčia, kai reikia surasti elementą, o jo ten nėra - tada paima Default reikšmę
            // SequenceEqual - palyginimas, pav. kruva1.SequenceEqual(kruva2)
            // OrderBy - rūšiavimas, : OrderBy s.StudentName descending; jei reikia antros pakopos - ThenBy 
            // Concat - sujungia, : col1.Concat(coll2)
            // Group - grupavimas: group s by s.Age;
            // DefaultIfEmpty - pakeičia rinkinio null elementus į default reikšmę
            // Empty - tuštiems elementams grąžinti
            // Range - tam tikras intervalas: .Range(10, 19)
            // Skip - praleidžia nurodytą skaičių elementų; SkipWhile - skipinam su sąlyga 
            // Take - paimti nurodyta skaičių elementų; TakeWhile - su sąlyga
            // AsEnumerable - konversija as 
            // ToLookup - into Lookup<TKey, TElement> (gali turėti pasikartojančius
            // Join - sujungia abejų lentelių (krūvų) informaciją (kaip SQL)
            //  join ... on post.ID equals meta.PostID  
            //
            // GroupJoin - kaip Join, bet dirba su grupėmis
            // Let - galima sukurti Alias (ilgų pasikartojančių komandų sinonimus): let lowercasename = s.Studetname.toLower() 
            // Into - rezultato patalpinimas į kitą kintąmąjį. select s Into teenStudent where ..


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
