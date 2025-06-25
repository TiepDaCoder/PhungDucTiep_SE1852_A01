using BusinessObjects;

namespace DataAccessLayer
{
    public class OrderDetailDAO
    {
        private static List<OrderDetail> orderDetails = new List<OrderDetail>();
        private static bool isInitialized = false;
        public OrderDetailDAO() { }
        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            orderDetails.Add(new OrderDetail { OrderID = 1, ProductID = 1, UnitPrice = 18.00, Quantity = 10, Discount = 0 });
            orderDetails.Add(new OrderDetail { OrderID = 1, ProductID = 2, UnitPrice = 19.00, Quantity = 5, Discount = 0.1f });

            orderDetails.Add(new OrderDetail { OrderID = 2, ProductID = 3, UnitPrice = 10.00, Quantity = 8, Discount = 0 });

            orderDetails.Add(new OrderDetail { OrderID = 3, ProductID = 4, UnitPrice = 22.00, Quantity = 6, Discount = 0.05f });

            orderDetails.Add(new OrderDetail { OrderID = 4, ProductID = 5, UnitPrice = 21.35, Quantity = 4, Discount = 0 });
            orderDetails.Add(new OrderDetail { OrderID = 4, ProductID = 6, UnitPrice = 25.00, Quantity = 3, Discount = 0.2f });

            orderDetails.Add(new OrderDetail { OrderID = 5, ProductID = 7, UnitPrice = 30.00, Quantity = 2, Discount = 0 });

            orderDetails.Add(new OrderDetail { OrderID = 6, ProductID = 8, UnitPrice = 40.00, Quantity = 5, Discount = 0 });
            orderDetails.Add(new OrderDetail { OrderID = 6, ProductID = 9, UnitPrice = 97.00, Quantity = 1, Discount = 0.3f });

            orderDetails.Add(new OrderDetail { OrderID = 7, ProductID = 10, UnitPrice = 31.00, Quantity = 6, Discount = 0 });

            orderDetails.Add(new OrderDetail { OrderID = 8, ProductID = 11, UnitPrice = 21.00, Quantity = 7, Discount = 0.15f });

            orderDetails.Add(new OrderDetail { OrderID = 9, ProductID = 12, UnitPrice = 38.00, Quantity = 3, Discount = 0 });
            orderDetails.Add(new OrderDetail { OrderID = 9, ProductID = 13, UnitPrice = 6.00, Quantity = 10, Discount = 0.05f });

            orderDetails.Add(new OrderDetail { OrderID = 10, ProductID = 14, UnitPrice = 23.25, Quantity = 4, Discount = 0 });
            orderDetails.Add(new OrderDetail { OrderID = 10, ProductID = 15, UnitPrice = 15.50, Quantity = 8, Discount = 0.1f });

            isInitialized = true;
        }
        public List<OrderDetail> GetAllOrderDetails()
        {
            if (!isInitialized)
            {
                Initialize();
            }
            return orderDetails;
        }
    }
}
