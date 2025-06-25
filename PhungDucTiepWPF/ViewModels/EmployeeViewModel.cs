using System.Windows.Input;
using BusinessObjects;
using PhungDucTiepWPF.Commands;

namespace PhungDucTiepWPF.ViewModels
{
    public class EmployeeViewModel
    {
        public string Greeting { get; set; }

        public ICommand ManageCustomersCommand { get; }
        public ICommand ManageProductsCommand { get; }
        public ICommand ManageOrdersCommand { get; }
        public ICommand ReportsCommand { get; }
        public ICommand LogoutCommand { get; }

        // Events để thông báo cho View
        public event Action? RequestOpenCustomers;
        public event Action? RequestOpenProducts;
        public event Action? RequestOpenOrders;
        public event Action? RequestOpenReports;
        public event Action? RequestLogout;

        public EmployeeViewModel(Employee employee)
        {
            Greeting = $"Welcome, {employee.Name}!";

            ManageCustomersCommand = new RelayCommand(() => RequestOpenCustomers?.Invoke());
            ManageProductsCommand = new RelayCommand(() => RequestOpenProducts?.Invoke());
            ManageOrdersCommand = new RelayCommand(() => RequestOpenOrders?.Invoke());
            ReportsCommand = new RelayCommand(() => RequestOpenReports?.Invoke());
            LogoutCommand = new RelayCommand(() => RequestLogout?.Invoke());
        }
    }
}