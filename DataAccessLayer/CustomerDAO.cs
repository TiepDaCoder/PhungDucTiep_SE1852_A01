using BusinessObjects;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private static List<Customer> customers = new List<Customer>();
        private static bool isInitialized = false;
        public CustomerDAO() { }
        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            customers.Add(new Customer { CustomerID = 1, CompanyName = "Alfreds Futterkiste", ContactName = "Maria Anders", ContactTitle = "Sales Representative", Address = "Obere Str. 57", Phone = "030-0074321" });
            customers.Add(new Customer { CustomerID = 2, CompanyName = "Ana Trujillo Emparedados y helados", ContactName = "Ana Trujillo", ContactTitle = "Owner", Address = "Avda. de la Constitución 2222", Phone = "(5) 555-4729" });
            customers.Add(new Customer { CustomerID = 3, CompanyName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", ContactTitle = "Owner", Address = "Mataderos  2312", Phone = "(5) 555-3932" });
            customers.Add(new Customer { CustomerID = 4, CompanyName = "Around the Horn", ContactName = "Thomas Hardy", ContactTitle = "Sales Representative", Address = "120 Hanover Sq.", Phone = "(171) 555-7788" });
            customers.Add(new Customer { CustomerID = 5, CompanyName = "Berglunds snabbköp", ContactName = "Christina Berglund", ContactTitle = "Order Administrator", Address = "Berguvsvägen  8", Phone = "0921-12 34 65" });
            customers.Add(new Customer { CustomerID = 6, CompanyName = "Blauer See Delikatessen", ContactName = "Hanna Moos", ContactTitle = "Sales Representative", Address = "Forsterstr. 57", Phone = "0621-08460" });
            customers.Add(new Customer { CustomerID = 7, CompanyName = "Blondesddsl père et fils", ContactName = "Frédérique Citeaux", ContactTitle = "Marketing Manager", Address = "24, place Kléber", Phone = "88.60.15.31" });
            customers.Add(new Customer { CustomerID = 8, CompanyName = "Bólido Comidas preparadas", ContactName = "Martín Sommer", ContactTitle = "Owner", Address = "C/ Araquil, 67", Phone = "(91) 555 22 82" });
            customers.Add(new Customer { CustomerID = 9, CompanyName = "Bon app'", ContactName = "Laurence Lebihan", ContactTitle = "Owner", Address = "12, rue des Bouchers", Phone = "91.24.45.40" });
            customers.Add(new Customer { CustomerID = 10, CompanyName = "Bottom-Dollar Markets", ContactName = "Elizabeth Lincoln", ContactTitle = "Accounting Manager", Address = "23 Tsawassen Blvd.", Phone = "(604) 555-4729" });

            isInitialized = true;
        }
        public List<Customer> GetAllCustomers()
        {
            if (!isInitialized)
            {
                Initialize();
            }
            return customers;
        }
        public Customer getCustomerAccount(string phone)
        {
            return customers.FirstOrDefault(customer => customer.Phone == phone);
        }
        public bool UpdateCustomer(Customer updatedCustomer)
        {
            var existing = customers.FirstOrDefault(c => c.CustomerID == updatedCustomer.CustomerID);
            if (existing != null)
            {
                existing.CompanyName = updatedCustomer.CompanyName;
                existing.ContactName = updatedCustomer.ContactName;
                existing.ContactTitle = updatedCustomer.ContactTitle;
                existing.Address = updatedCustomer.Address;
                existing.Phone = updatedCustomer.Phone;
                return true;
            }
            return false;
        }
        public void Add(Customer c)
        {
            int newId = customers.Count > 0 ? customers.Max(x => x.CustomerID) + 1 : 1;
            c.CustomerID = newId;
            customers.Add(c);
        }
        public void Delete(int id)
        {
            var c = customers.FirstOrDefault(x => x.CustomerID == id);
            if (c != null) customers.Remove(c);
        }
        public List<Customer> Search(string keyword)
        {
            return customers.Where(c =>
                c.CompanyName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                c.ContactName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                c.Phone.Contains(keyword)).ToList();
        }
    }
}