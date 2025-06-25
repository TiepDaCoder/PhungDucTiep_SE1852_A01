using BusinessObjects;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO _orderDAO;

        public OrderRepository()
        {
            _orderDAO = new OrderDAO();
            _orderDAO.Initialize();
        }

        public List<Order> GetOrdersByCustomerID(int customerId)
        {
            return _orderDAO.GetAllOrders().Where(o => o.CustomerID == customerId).ToList();
        }
    }
}