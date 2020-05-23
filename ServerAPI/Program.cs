using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace ServerAPI
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
                    webBuilder.ConfigureKestrel(serverOptions =>
                    {
                        serverOptions.Listen(IPAddress.Loopback, 5001,
                            listenOptions =>
                            {
                                listenOptions.UseHttps("localhost.pfx",
                                    "P@55w0rd1");
                            });
                        // Set properties and call methods on options
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}