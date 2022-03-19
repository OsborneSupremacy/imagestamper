using Microsoft.Extensions.Hosting;

namespace ImageStamper.Client
{
    public class ConsoleHostedService : IHostedService
    {
        private readonly IHostApplicationLifetime _applicationLifetime;

        private readonly MainForm _mainForm;

        public ConsoleHostedService(
            IHostApplicationLifetime applicationLifetime,
            MainForm mainForm)
        {
            _applicationLifetime = applicationLifetime ?? throw new ArgumentNullException(nameof(applicationLifetime));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _applicationLifetime.ApplicationStarted.Register(() =>
            {
                try
                {
                    Application.Run(_mainForm);
                }
                catch (Exception)
                {
                }
                finally
                {
                    _applicationLifetime.StopApplication();
                }
            });
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}