namespace Exemplos
{
    public class OrderServiceDI
    {
        private readonly OrderRepository _repository;

        public OrderServiceDI(OrderRepository repository)
        {
            _repository = repository;
        }
    }
}