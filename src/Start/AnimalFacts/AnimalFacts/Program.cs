using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AnimalFacts.Contexts;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AnimalFacts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = MigrateData(CreateWebHostBuilder(args).Build());
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        /// <summary>
        /// Runs the db migration at startup
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public static IWebHost MigrateData(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetService<AnimalContext>();
                context.Database.Migrate();
            }

            return host;
        }
    }
}
