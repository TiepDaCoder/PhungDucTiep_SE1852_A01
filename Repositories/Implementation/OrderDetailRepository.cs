using BusinessObjects;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderDetailDAO _orderDetailDAO;

        public OrderDetailRepository()
        {
            _orderDetailDAO = new OrderDetailDAO();
            _orderDetailDAO.Initialize();
        }

        public List<OrderDetail> GetAll() => _orderDetailDAO.GetAllOrderDetails();

        public List<OrderDetail> GetByOrderId(int orderId)
        {
            return _orderDetailDAO.GetAllOrderDetails()
                                  .Where(d => d.OrderID == orderId)
                                  .ToList();
        }

        public void Add(OrderDetail detail)
        {
            _orderDetailDAO.AddOrderDetail(detail);
        }

        public void DeleteDetailsByOrderId(int orderId)
        {
            _orderDetailDAO.DeleteOrderDetailsByOrderId(orderId);
        }
    }
}