using BusinessObjects;

namespace Services.Interface
{
    public interface IEmployeeService
    {
        Employee Login(string username, string password);
    }
}
