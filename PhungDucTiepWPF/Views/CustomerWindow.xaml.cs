using System.Windows;
using BusinessObjects;
using PhungDucTiepWPF.ViewModels;

namespace PhungDucTiepWPF.Views
{
    public partial class CustomerWindow : Window
    {
        private Customer _currentCustomer;

        public CustomerWindow(Customer customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
            this.DataContext = new CustomerViewModel(_currentCustomer);
            txtGreeting.Text = $"Welcome, {_currentCustomer.ContactName}!";
        }

        private void ViewOrders_Click(object sender, RoutedEventArgs e)
        {
            var ordersWindow = new OrderHistoryWindow(_currentCustomer.CustomerID);
            ordersWindow.Owner = this;
            ordersWindow.ShowDialog();
        }

        private void ManageRooms_Click(object sender, RoutedEventArgs e)
        {
            //var roomWindow = new RoomManagementWindow();
            //roomWindow.ShowDialog();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new Login();
            loginWindow.Show();
            this.Close();
        }
    }
}
