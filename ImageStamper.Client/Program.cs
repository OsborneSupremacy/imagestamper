using ImageStamper.Service;
using ImageStamper.Utility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ImageStamper.Client;

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

                services.AddOptions<Settings>()
                    .Bind(configuration.GetSection("Settings"))
                    .ValidateDataAnnotations();

                typeof(Processor).GetTypesInAssembly().ForEach(x =>
                {
                    services.AddSingleton(x);
                });

                services.AddSingleton<MainForm>();
            })
            .RunConsoleAsync();
    }
}
