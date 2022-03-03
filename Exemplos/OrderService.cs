using System.Data.SqlClient;

namespace Exemplos
{
    public class OrderService
    {
        private readonly OrderRepository _repository;
        public OrderService()
        {
            // Caso fosse necessário alterar o acesso ao banco de SqlServer -> MySql
            // a classe OrderService seria impactada.
            _repository = new OrderRepository(new SqlConnection("CONNECTION_STRING"));
        }
    }
}