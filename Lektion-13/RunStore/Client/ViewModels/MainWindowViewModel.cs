using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView = new();
    private readonly ProductsViewModel _productView = new();

    [ObservableProperty]
    private ViewModelBase _currentView;

    public MainWindowViewModel()
    {
        // Sätta vilken vy ska vara startsidan...
        CurrentView = _homeView;
    }

    [RelayCommand]
    private void GoToHome() => CurrentView = _homeView;

    [RelayCommand]
    private void GoToProducts() => CurrentView = _productView;
}
