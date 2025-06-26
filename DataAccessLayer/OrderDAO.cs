using BusinessObjects;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        private static List<Order> orders = new List<Order>();
        private static bool isInitialized = false;
        public OrderDAO() { }
        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            orders.Add(new Order { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = new DateTime(2024, 1, 10) });
            orders.Add(new Order { OrderID = 6, CustomerID = 1, EmployeeID = 6, OrderDate = new DateTime(2024, 2, 17) });
            orders.Add(new Order { OrderID = 2, CustomerID = 2, EmployeeID = 3, OrderDate = new DateTime(2024, 2, 15) });
            orders.Add(new Order { OrderID = 3, CustomerID = 3, EmployeeID = 2, OrderDate = new DateTime(2024, 3, 20) });
            orders.Add(new Order { OrderID = 4, CustomerID = 4, EmployeeID = 4, OrderDate = new DateTime(2024, 4, 5) });
            orders.Add(new Order { OrderID = 5, CustomerID = 5, EmployeeID = 5, OrderDate = new DateTime(2024, 5, 12) });
            orders.Add(new Order { OrderID = 6, CustomerID = 6, EmployeeID = 6, OrderDate = new DateTime(2024, 6, 8) });
            orders.Add(new Order { OrderID = 7, CustomerID = 7, EmployeeID = 1, OrderDate = new DateTime(2024, 7, 1) });
            orders.Add(new Order { OrderID = 8, CustomerID = 8, EmployeeID = 2, OrderDate = new DateTime(2024, 7, 15) });
            orders.Add(new Order { OrderID = 9, CustomerID = 9, EmployeeID = 3, OrderDate = new DateTime(2024, 8, 10) });
            orders.Add(new Order { OrderID = 10, CustomerID = 10, EmployeeID = 4, OrderDate = new DateTime(2024, 9, 5) });

            isInitialized = true;
        }
        public List<Order> GetAllOrders()
        {
            if (!isInitialized)
            {
                Initialize();
            }
            return orders;
        }
        public void AddOrder(Order order)
        {
            order.OrderID = orders.Count > 0 ? orders.Max(o => o.OrderID) + 1 : 1;
            orders.Add(order);
        }

        public void DeleteOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderID == orderId);
            if (order != null) orders.Remove(order);
        }

        public List<Order> SearchOrders(int? customerId, int? employeeId)
        {
            return orders.Where(o =>
                (!customerId.HasValue || o.CustomerID == customerId) &&
                (!employeeId.HasValue || o.EmployeeID == employeeId)).ToList();
        }
    }
}
