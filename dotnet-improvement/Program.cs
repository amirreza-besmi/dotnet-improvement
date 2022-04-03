using dotnet_improvement.Presentation.Testers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace dotnet_improvement.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AnonymousMethodTester.TestAnonymousMethod();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
