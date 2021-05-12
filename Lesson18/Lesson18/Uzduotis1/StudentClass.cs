using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.Uzduotis1
{
    class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double AvarageMark { get; set; }
        public bool IsGettingTuition { get; set; }

        
        public Student()//int id, string name, int age)
        {
            //Id = id;

        }

        public int CompareTo(Student other)
        {
            //throw new NotImplementedException();
            return this.Age - other.Age;
        }
    }
}
