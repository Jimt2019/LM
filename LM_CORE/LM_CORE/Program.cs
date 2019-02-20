using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LM_CORE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContent, config) =>{
                var env = hostingContent.HostingEnvironment;
                config.AddJsonFile("appsetting.json", optional: true, reloadOnChange: true).
                AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true).
                AddJsonFile("Content.json", optional: false, reloadOnChange: false).AddEnvironmentVariables();
            }).UseStartup<Startup>();
    }
}
