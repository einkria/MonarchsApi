/*
 * Web API that delivers data on English Monarchs.
 * Author: Krist�n ��ra J�kulsd�ttir
 */
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MonarchsApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
