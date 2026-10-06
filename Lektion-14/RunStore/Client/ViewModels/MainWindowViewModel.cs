using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView = new();
    private readonly ProductsViewModel _productView = new();
    private readonly CustomersViewModel _customerView = new();
    private readonly OrdersViewModel _orderView = new();

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    public MainWindowViewModel()
    {
        // Sätta vilken vy ska vara startsidan...
        CurrentView = _homeView;
    }

    [RelayCommand]
    private void GoToHome() => CurrentView = _homeView;

    [RelayCommand]
    private void GoToProducts() => CurrentView = _productView;
    [RelayCommand]
    private void GoToCustomers() => CurrentView = _customerView;
    [RelayCommand]
    private void GoToOrders() => CurrentView = _orderView;
}
