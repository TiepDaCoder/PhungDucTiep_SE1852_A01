using BusinessObjects;

namespace Repositories.Interface
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeAccount(string username, string password);
        List<Employee> GetAllEmployees();
    }

}
