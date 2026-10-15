using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomersViewModel : ViewModelBase
{
    private readonly CustomerService _customerService;
    // private readonly ICustomerService _customerService;

    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];

    public CustomersViewModel()
    {
        PageTitle = "Kunder";
        _customerService = new CustomerService();
        LoadCustomers();
    }

    private void LoadCustomers()
    {
        // var customers = _customerService.ListAll();
        // Customers = new ObservableCollection<Customer>(customers);
        Customers = new ObservableCollection<Customer>(_customerService.ListAll());
    }
}
