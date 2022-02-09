using InjecaoDependencia.Service;

namespace InjecaoDependencia.Application
{
    public class Application : IApplicationOne, IApplicationTwo
    {
        private readonly ISingletonService _singleton;
        private readonly IScopedService _scoped;
        private readonly ITransientService _transient;
        private readonly ILogger<Application> _logger;

        public Application(ISingletonService singleton, IScopedService scoped, ITransientService transient, ILogger<Application> logger)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
            _logger = logger;
        }

        public void Print(int number)
        {
            _logger.LogDebug($"===================== EXECUÇÃO {number} =====================");
            _logger.LogDebug($"SINGLETON: {_singleton.GetId()} | SCOPED: {_scoped.GetId()} | TRANSIENT: {_transient.GetId()}");
        }
    }
}