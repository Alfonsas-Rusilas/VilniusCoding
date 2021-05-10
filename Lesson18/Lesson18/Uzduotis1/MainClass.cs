using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.Uzduotis1
{
    class MainClass
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 0, Name = "Kestas", Age = 30, AvarageMark = 6.1, IsGettingTuition = true },
                new Student() { Id = 1, Name = "Ona", Age = 25, AvarageMark = 9.4, IsGettingTuition = false },
                new Student() { Id = 2, Name = "Petras", Age = 21, AvarageMark = 5.3, IsGettingTuition = true },
                new Student() { Id = 3, Name = "Gabija", Age = 19, AvarageMark = 8.2, IsGettingTuition = false },
                new Student() { Id = 4, Name = "Jonas", Age = 17, AvarageMark = 4.5, IsGettingTuition = true },
                new Student() { Id = 5, Name = "Biata", Age = 15, AvarageMark = 9.2, IsGettingTuition = false }
            };


            List<Student> JauGali = students.FindAll(a => a.Age > 21);
            List<Student> ValstybesRemiami = students.FindAll(a => a.AvarageMark > 8);
            List<Student> MultiStudentai = students.FindAll(a => (a.AvarageMark <4 && a.Name.Length<=8));


        }
    }
}
