using BusinessObjects;

namespace Services.Interface
{
    public interface IOrderService
    {
        List<Order> GetOrdersForCustomer(int customerId);
    }
}