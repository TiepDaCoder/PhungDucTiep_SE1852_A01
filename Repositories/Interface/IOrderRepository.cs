using BusinessObjects;

namespace Repositories.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetOrdersByCustomerID(int customerId);
    }
}