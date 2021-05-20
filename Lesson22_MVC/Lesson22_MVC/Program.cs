using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            // [ActionName ("find")]
            // public ActionResult GetById(int id)
            // 
            // Syste.Web.Razor - microsoft pl�tojamas interfeisas
            // var id = Request.
            // Student/Edit?id=1&name=John
            // 
            //wwwroot // naudojami statiniai failai
            //Controller // smegenys, apdoroja visus URL regustus
            //Views //vaizdai
            //Shared // elementams, kurie naudojami keliuose puslapiuose
            //appsettings.json // servis� ir prisijungim� parametrai, pav. DB


            //            Lesson23_SQL

            //Bazi� modeliai:
            //            -Reliacin�s //da�nai naudojamos, MySQL, SQL, Oracle, ...
            //            - Tinklinis
            //            - Hierarchinis
            //            - Objektinis


            //Primary key -�ra�o lentel�je identifikacija(uniklaus). Gali b�ti sudarytas i� keli� lauk�
            //Foreign key -s�ry�is su kita DB lentele, pav. Pirma lentel� turi primary key, tai antra tur�s ry�� pagal Foreign key


            //View > Other Window > Package Manager Console
            //PM > add - migration CreateStudent //Migrations: du failiukai susikuria

            //   Prie double prira�ytas double? paver�ia j� objektu
            //   [Range(0.0, 10.0)]
            //public double? Score { get; set; }

            //        View > Other Window > Package Manager Console
            //PM> update-database	// sukuria konkre�ias lenteles
            //Build started...
            //Build succeeded.
            //Done.
            //PM> 

            //SQLConnection
            //SQLCommand
            //SQLDataReader

            // ORM - Object relational mapper
            // dirbti su SQL naudojant C# klases;
            // Entity framework - gan populiarus ORM
            //
        }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
