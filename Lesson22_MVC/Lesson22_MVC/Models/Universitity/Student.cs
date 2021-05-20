using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC.Models.Universitity
{

    
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0.0, 10.0)]
        public double? Score { get; set; }
        public string City { get; set; }
        public bool IsGettingTuition { get; set; }

        public string Pravarde { get; set; }

        public override string ToString()
        {
            return $"Student(Id:{Id}, Name:{Name}, Score:{Score}, City:{City}, IsGettingTuition:{IsGettingTuition}, Pravarde:{Pravarde})";
        }



    }




}
