using dotnet_improvement.Testers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace dotnet_improvement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DelegateTester.StartMultiCastDelegateProcess();

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
