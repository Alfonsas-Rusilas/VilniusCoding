using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC.Models.Universitity
{
    public class StudentSubject
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student student { get; set; }
        public Subject subject { get; set; }
        public int SubjectId { get; set; }
    }
}
