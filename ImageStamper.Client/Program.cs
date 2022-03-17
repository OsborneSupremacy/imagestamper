using ImageStamper.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System.Linq;

namespace ImageStamper.Client
{
    internal static class Program
    {
        static async Task Main()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            await Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<ConsoleHostedService>();

                    Assembly.GetAssembly(typeof(Processor))!
                        .GetTypes()
                        .Where(x => !x.IsAbstract)
                        .Where(x => x.IsPublic)
                        .ToList()
                        .ForEach(x => {
                            services.AddSingleton(x);
                        });

                    services.AddSingleton<MainForm>();
                })
                .RunConsoleAsync();
        }

    }
}