using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];

    public ProductsViewModel()
    {
        PageTitle = "Våra produkter";
        LoadProducts();
    }

    private void LoadProducts()
    {
        try
        {
            // IProductService service = new ProductService();
            IProductService service = new ProductService();
            Products = new ObservableCollection<Product>(service.ListAll());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    [RelayCommand]
    private void Edit(string id)
    {
        Console.WriteLine("Uppdaterar produkt med id: " + id);
    }

    [RelayCommand]
    private void Delete(string id)
    {
        Console.WriteLine("Tar bort produkt med id: " + id);
    }
}
