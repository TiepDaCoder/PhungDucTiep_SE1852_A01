using System.Windows;
using BusinessObjects;
using PhungDucTiepWPF.ViewModels;

namespace PhungDucTiepWPF.Views
{
    public partial class EmployeeWindow : Window
    {
        private readonly EmployeeViewModel _viewModel;

        public EmployeeWindow(Employee employee)
        {
            InitializeComponent();

            _viewModel = new EmployeeViewModel(employee);
            _viewModel.RequestOpenCustomers += () => new CustomerManagementWindow().ShowDialog();
            _viewModel.RequestOpenProducts += () => new ProductManagementWindow().ShowDialog();
            _viewModel.RequestOpenOrders += () => MessageBox.Show("Order window placeholder.");
            _viewModel.RequestOpenReports += () => MessageBox.Show("Reports window placeholder.");
            _viewModel.RequestLogout += () =>
            {
                new Login().Show();
                this.Close();
            };

            DataContext = _viewModel;
        }
    }
}