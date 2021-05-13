using System;

namespace Lesson19
{
    class Student  
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

        //public int CompareTo(Student other)
        //{
        //    //throw new NotImplementedException();
        //    return this.Age - other.Age;
        //}
    }
}