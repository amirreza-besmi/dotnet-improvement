using dotnet_improvement.Presentation.Testers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace dotnet_improvement.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program.Test();

            CreateHostBuilder(args).Build().Run();
        }

        public void Test()
        {
            Console.WriteLine("test()");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
