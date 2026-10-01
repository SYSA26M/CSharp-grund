
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

// Vårt DataContext
public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _manufacturer = "Volvo";

    [ObservableProperty]
    private string _model = "XC40";

    [RelayCommand]
    public void AddVehicle()
    {
        Manufacturer = "Kia";
        Model = "EV3";
    }
}
