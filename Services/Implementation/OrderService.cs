using BusinessObjects;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public List<Order> GetOrdersForCustomer(int customerId)
        {
            return _orderRepository.GetOrdersByCustomerID(customerId);
        }
    }
}