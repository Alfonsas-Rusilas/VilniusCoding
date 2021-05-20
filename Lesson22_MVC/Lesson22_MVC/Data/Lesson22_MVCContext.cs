using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesson22_MVC.Models.Universitity;

namespace Lesson22_MVC.Data
{
    public class Lesson22_MVCContext : DbContext
    {
        public Lesson22_MVCContext (DbContextOptions<Lesson22_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Lesson22_MVC.Models.Universitity.Student> Student { get; set; }
        public DbSet<Lesson22_MVC.Models.Universitity.Adress> Adresses { get; set; }
        public DbSet<Lesson22_MVC.Models.Universitity.Subject> Subject { get; set; }
        public DbSet<Lesson22_MVC.Models.Universitity.StudentSubject> StudentSubject { get; set; }


    }
}
