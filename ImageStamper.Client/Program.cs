using ImageStamper.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

                    services.AddSingleton<BoundaryCalculator>();
                    services.AddSingleton<BrushService>();
                    services.AddSingleton<CoordinatesService>();
                    services.AddSingleton<DrawingService>();
                    services.AddSingleton<ExifExtractor>();
                    services.AddSingleton<FontService>();
                    services.AddSingleton<Service.ImageConverter>();
                    services.AddSingleton<StampSizeService>();
                    services.AddSingleton<Processor>();

                    services.AddSingleton<MainForm>();
                    ///services.RegisterServices();
                })
                .RunConsoleAsync();
        }

    }
}