using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly: HostingStartup(typeof(Kasica.Areas.Identity.IdentityHostingStartup))]
namespace Kasica.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {

            builder.ConfigureServices((services) =>
            {
                services.AddLogging(builder =>
                {
                    builder.AddDebug()
                        .AddConsole()
                        .SetMinimumLevel(LogLevel.Warning)
                        .AddFilter("Aguacongas.Identity.Redis", LogLevel.Trace);
                });
            });

        }
    }
}