using BusinessObjects;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDAO _employeeDAO;

        public EmployeeRepository()
        {
            _employeeDAO = new EmployeeDAO();
            _employeeDAO.Initialize();
        }
        public Employee GetEmployeeAccount(string username, string password)
        {
            return _employeeDAO.GetEmployeeAccount(username, password);
        }
        public List<Employee> GetAllEmployees()
        {
            return _employeeDAO.GetAllEmployees();
        }
    }
}
