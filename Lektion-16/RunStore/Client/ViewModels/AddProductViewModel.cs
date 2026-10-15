using System;
using System.Dynamic;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class AddProductViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string ItemNumber { get; set; } = string.Empty;
    [ObservableProperty]
    public partial string ProductName { get; set; } = string.Empty;
    [ObservableProperty]
    public partial string Supplier { get; set; } = string.Empty;
    [ObservableProperty]
    public partial string Price { get; set; } = string.Empty;

    public AddProductViewModel()
    {
        PageTitle = "Ny Produkt";
    }

    [RelayCommand]
    private void Add()
    {
        try
        {
            // Glöm inte att validera fälten!!!
            var product = new Product
            {
                ItemNumber = ItemNumber,
                Name = ProductName,
                SupplierName = Supplier,
                Price = int.Parse(Price)
            };

            var service = new ProductService();
            service.Add(product);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
