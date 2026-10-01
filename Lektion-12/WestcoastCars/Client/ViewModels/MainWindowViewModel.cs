using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Client.ViewModels;

// Vårt DataContext
public class MainWindowViewModel : INotifyPropertyChanged
{
    private string _manufacturer = "Volvo";
    private string _model = "XC40";

    public string Manufacturer
    {
        get => _manufacturer;
        set
        {
            _manufacturer = value;
            OnPropertyChanged();
        }
    }

    public string Model
    {
        get => _model;
        set
        {
            _model = value;
            OnPropertyChanged(nameof(Model));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void AddVehicle()
    {
        Console.WriteLine($"Den gamla tillverkaren: {Manufacturer}");
        Manufacturer = "Kia";
        Model = "EV6";
        Console.WriteLine($"Lade till {Manufacturer}");
    }
}
