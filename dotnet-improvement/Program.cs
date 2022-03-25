using dotnet_improvement.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace dotnet_improvement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoreHelper.StartDelegateProcess();
            CoreHelper.StartFuncProcess();
            CoreHelper.StartActionProcess();

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
