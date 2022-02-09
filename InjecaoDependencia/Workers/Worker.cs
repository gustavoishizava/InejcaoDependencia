using InjecaoDependencia.Application;

namespace InjecaoDependencia.Workers
{
    public class Worker : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<Worker> _logger;

        public Worker(IServiceProvider serviceProvider, ILogger<Worker> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Start();
                Start();
                await Task.Delay(5000);
            }
        }

        private void Start()
        {
            using var scope = _serviceProvider.CreateScope();

            var app = scope.ServiceProvider.GetRequiredService<IApplicationOne>();
            var app2 = scope.ServiceProvider.GetRequiredService<IApplicationTwo>();
            app.Print(1);
            app2.Print(2);

            scope.Dispose();
        }
    }
}