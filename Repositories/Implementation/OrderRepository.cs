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

        public List<Order> GetAll() => _orderDAO.GetAllOrders();

        public void Add(Order order) => _orderDAO.AddOrder(order);

        public void Delete(int orderId) => _orderDAO.DeleteOrder(orderId);

        public List<Order> Search(int? customerId, int? employeeId)
        {
            var query = _orderDAO.GetAllOrders().AsQueryable();

            if (customerId.HasValue)
                query = query.Where(o => o.CustomerID == customerId.Value);

            if (employeeId.HasValue)
                query = query.Where(o => o.EmployeeID == employeeId.Value);

            return query.ToList();
        }
        public List<OrderReportModel> GetReportByMonth() => _orderDAO.GetReportByMonth();
    }
}