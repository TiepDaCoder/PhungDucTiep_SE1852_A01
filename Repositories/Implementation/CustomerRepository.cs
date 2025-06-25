using BusinessObjects;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDAO _customerDAO;

        public CustomerRepository()
        {
            _customerDAO = new CustomerDAO();
            _customerDAO.Initialize();
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerDAO.GetAllCustomers();
        }

        public Customer GetCustomerAccount(string phone)
        {
            return _customerDAO.getCustomerAccount(phone);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerDAO.UpdateCustomer(customer);
        }

        public void Add(Customer c)
        {
            _customerDAO.Add(c);
        }

        public void Delete(int id)
        {
            _customerDAO.Delete(id);
        }

        public List<Customer> Search(string keyword)
        {
            return _customerDAO.Search(keyword);
        }
    }
}