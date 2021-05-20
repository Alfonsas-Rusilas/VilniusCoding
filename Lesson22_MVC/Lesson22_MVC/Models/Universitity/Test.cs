using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC.Models.Universitity
{
    public class Test
    {

        //struct
        public int Nr { get; set; }
        public int? NrNotNull { get; set; }

        //class
        public Student student { get; set; } // can be null
        
        [Required]
        public Student student2 { get; set; } // Not null

        [NotMapped]
        public int mysecretvar;


    }
}
