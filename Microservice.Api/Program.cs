using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Microservice
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();



        public static void Main(string[] args)
        {
            try
            {
                CreateWebHostBuilder(args)
                .Build()
                .Run();
            }
            catch(Exception ex)
            {
            }
            finally
            {
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseStartup<Startup>();
        }
}
