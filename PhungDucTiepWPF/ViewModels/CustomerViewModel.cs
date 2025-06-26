using System.Windows.Input;
using BusinessObjects;
using PhungDucTiepWPF.Commands;
using Services.Implementation;

namespace PhungDucTiepWPF.ViewModels
{
    public class CustomerViewModel
    {
        private readonly CustomerService _customerService;
        public Customer Customer { get; set; }

        public ICommand EditProfileCommand { get; }
        public ICommand ViewOrdersCommand { get; }
        public ICommand LogoutCommand { get; }

        public event Action RequestLogout;
        public event Action<Customer> RequestEditProfile;
        public event Action<int> RequestOpenOrders;

        public CustomerViewModel(Customer customer)
        {
            Customer = customer;
            _customerService = new CustomerService();

            EditProfileCommand = new RelayCommand(OnEditProfile);
            ViewOrdersCommand = new RelayCommand(OnViewOrders);
            LogoutCommand = new RelayCommand(OnLogout);
        }

        private void OnEditProfile()
        {
            RequestEditProfile?.Invoke(Customer);
        }

        private void OnViewOrders()
        {
            RequestOpenOrders?.Invoke(Customer.CustomerID);
        }

        private void OnLogout()
        {
            RequestLogout?.Invoke();
        }

        public void UpdateProfile(Customer updated)
        {
            Customer.CompanyName = updated.CompanyName;
            Customer.ContactName = updated.ContactName;
            Customer.ContactTitle = updated.ContactTitle;
            Customer.Address = updated.Address;
            Customer.Phone = updated.Phone;

            _customerService.UpdateCustomer(Customer);
        }
    }
}