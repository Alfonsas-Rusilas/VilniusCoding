using Lesson18.Uzduotis1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.Uzduotis2.Extensions
{
    static class IntExtensions
    {
        public static int PowerTwo(this int data)
        {
            return data * data; 
        }

        public static string PowerStudentName(this Student data)
        {
            return data.Name;
        }

        public static Student StudentsMember(this List<Student> data)
        {
            return data[0];
        }

    }
}
