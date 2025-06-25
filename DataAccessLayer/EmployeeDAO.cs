using BusinessObjects;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        private static List<Employee> employees = new List<Employee>();
        private static bool isInitialized = false;
        public EmployeeDAO() { }
        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            employees.Add(new Employee
            {
                EmployeeID = 1,
                Name = "Davolio",
                UserName = "Nancy",
                Password = "123",
                JobTitle = "Sales Representative",
                BirthDate = new DateTime(1948, 12, 8),
                HireDate = new DateTime(1992, 5, 1),
                Address = "507 - 20th Ave. E.Apt. 2A"
            });

            employees.Add(new Employee
            {
                EmployeeID = 2,
                Name = "Fuller",
                UserName = "Andrew",
                Password = "456",
                JobTitle = "Vice President, Sales",
                BirthDate = new DateTime(1952, 2, 19),
                HireDate = new DateTime(1992, 8, 14),
                Address = "908 W. Capital Way"
            });

            employees.Add(new Employee
            {
                EmployeeID = 3,
                Name = "Leverling",
                UserName = "Janet",
                Password = "789",
                JobTitle = "Sales Representative",
                BirthDate = new DateTime(1963, 8, 30),
                HireDate = new DateTime(1992, 4, 1),
                Address = "722 Moss Bay Blvd."
            });

            employees.Add(new Employee
            {
                EmployeeID = 4,
                Name = "Peacock",
                UserName = "Margaret",
                Password = "321",
                JobTitle = "Sales Representative",
                BirthDate = new DateTime(1937, 9, 19),
                HireDate = new DateTime(1993, 5, 3),
                Address = "4110 Old Redmond Rd."
            });

            employees.Add(new Employee
            {
                EmployeeID = 5,
                Name = "Buchanan",
                UserName = "Steven",
                Password = "654",
                JobTitle = "Sales Manager",
                BirthDate = new DateTime(1955, 3, 4),
                HireDate = new DateTime(1993, 10, 17),
                Address = "14 Garrett Hill"
            });

            employees.Add(new Employee
            {
                EmployeeID = 6,
                Name = "Suyama",
                UserName = "Michael",
                Password = "987",
                JobTitle = "Sales Representative",
                BirthDate = new DateTime(1963, 7, 2),
                HireDate = new DateTime(1993, 10, 17),
                Address = "Coventry House\nMiner Rd."
            });

            isInitialized = true;
        }
        public List<Employee> GetAllEmployees()
        {
            if (!isInitialized)
            {
                Initialize();
            }
            return employees;
        }
        public Employee GetEmployeeAccount(string username, string password)
        {
            return employees.FirstOrDefault(e => e.UserName == username && e.Password == password);
        }
    }
}
