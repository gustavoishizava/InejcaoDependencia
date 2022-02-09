namespace InjecaoDependencia.Service
{
    public class Service : ISingletonService, IScopedService, ITransientService
    {
        private readonly ILogger<Service> _logger;
        private readonly int _id;

        public Service(ILogger<Service> logger)
        {
            _logger = logger;
            _id = new Random().Next(1, 10000);
        }
        public int GetId()
        {
            return _id;
        }
    }
}