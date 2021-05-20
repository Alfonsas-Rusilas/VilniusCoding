using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC.Models.Universitity
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Street { get; set; }

        public int? HouseNr { get; set; }


        public int StudentId { get; set; }
        public Student Student{ get; set; }

    }
}
