using System.Windows;
using System.Windows.Input;
using BusinessObjects;
using PhungDucTiepWPF.Commands;
using PhungDucTiepWPF.Views;
using Services.Implementation;

namespace PhungDucTiepWPF.ViewModels
{
    public class CustomerViewModel
    {
        private readonly CustomerService _customerService;
        public Customer Customer { get; set; }

        public ICommand EditProfileCommand { get; }

        public CustomerViewModel(Customer customer)
        {
            Customer = customer;
            _customerService = new CustomerService();
            EditProfileCommand = new RelayCommand(EditProfile);
        }

        private void EditProfile()
        {
            var editWindow = new EditCustomerWindow(Customer)
            {
                Owner = Application.Current.MainWindow
            };

            if (editWindow.ShowDialog() == true)
            {
                var updated = editWindow.Customer;

                Customer.CompanyName = updated.CompanyName;
                Customer.ContactName = updated.ContactName;
                Customer.ContactTitle = updated.ContactTitle;
                Customer.Address = updated.Address;
                Customer.Phone = updated.Phone;

                _customerService.UpdateCustomer(Customer);

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}