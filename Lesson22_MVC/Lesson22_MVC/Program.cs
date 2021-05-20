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
            // Syste.Web.Razor - microsoft plëtojamas interfeisas
            // var id = Request.
            // Student/Edit?id=1&name=John
            // 
            //wwwroot // naudojami statiniai failai
            //Controller // smegenys, apdoroja visus URL regustus
            //Views //vaizdai
            //Shared // elementams, kurie naudojami keliuose puslapiuose
            //appsettings.json // servisø ir prisijungimø parametrai, pav. DB


            //            Lesson23_SQL

            //Baziø modeliai:
            //            -Reliacinës //daþnai naudojamos, MySQL, SQL, Oracle, ...
            //            - Tinklinis
            //            - Hierarchinis
            //            - Objektinis


            //Primary key -áraðo lentelëje identifikacija(uniklaus). Gali bûti sudarytas ið keliø laukø
            //Foreign key -sàryðis su kita DB lentele, pav. Pirma lentelë turi primary key, tai antra turës ryðá pagal Foreign key


            //View > Other Window > Package Manager Console
            //PM > add - migration CreateStudent //Migrations: du failiukai susikuria

            //   Prie double priraðytas double? paverèia já objektu
            //   [Range(0.0, 10.0)]
            //public double? Score { get; set; }

            //        View > Other Window > Package Manager Console
            //PM> update-database	// sukuria konkreèias lenteles
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
