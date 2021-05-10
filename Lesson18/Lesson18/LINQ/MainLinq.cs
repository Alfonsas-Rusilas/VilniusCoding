using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.LINQ
{
    class MainLinq
    {
        static void Main()
        {
            // LINQ - užklausų sintaksė gauti duomenims iš įvairiausių šaltinių.
            // Turi panašumą į SQL, tai yra atskira skriptavimo kalba
            // Galima dirbti su: Ado.net, 
            // Naudoja interfeisus: IEnumerable ir IQueryable
            // 
            // Using System.Linq

            //IList<string> stringList = new

            List<string> stringList = new List<string>()
            {
                "aaaaaa",
                "bbbbbbb",
                "cccc"
            };

            // Linq Query
            var result = from s in stringList
                         where s.Contains("Tutor")
                         select s;

            // Linq Method
            var result2 = stringList.Where(s => s.Contains("Tutor")); 

            //Linq Query sintaksė:
            IEnumerable<string> result5 = from s in stringList
                                          where s.Contains("Tutor")
                                          select s;


            List<string> result7 = (from s in stringList
                         where s.Contains("Tutor")
                         select s).ToList();

            string[] result8 = (from s in stringList
                                where s.Contains("Tutor")
                                select s).ToArray();


        }
    }
}
