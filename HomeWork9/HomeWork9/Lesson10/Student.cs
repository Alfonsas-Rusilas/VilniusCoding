using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Lesson10
{
    class Student
    {
        
        private int age;
        public int Age1 { get; set; }
        public int Age2 { get; set; } = 15;
        public int Age3 { get; } //tik skaitomas kintamasis
        public int Age4 { get; private set; } // įrašyti bus galima tik iš klasės vidaus;




        public int Age {
            get {
                return age;
            }
            set
            {
                if (value > 20)
                {
                    age = value;
                } 
            }
         }


        private string name;
        public string Name {
            get
            {
                return name;
            }
            set     // default yra set(string value)
            {
                name = value;
            }
        }

        public Student(string name)
        {
            this.name = name;
        }

        //public string GetName()
        //{
        //    return Name;
        //}

        //public void SetName(string name)
        //{
        //    this.Name = name;
        //}

    }
}
