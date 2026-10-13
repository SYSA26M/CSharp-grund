using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

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
        IProductService service = new ProductService();
        Products = new ObservableCollection<Product>(service.ListAll());

        // var products = service.ListAll();
        // Products = new ObservableCollection<Product>(products);
    }
}
