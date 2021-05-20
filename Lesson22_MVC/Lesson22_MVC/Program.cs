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

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
