using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class ProductService : IProductService
{
    private readonly string _path = string.Empty;
    private readonly Storage<Product> _storage;

    public ProductService()
    {
        _path = string.Concat(Environment.CurrentDirectory, "/Data/products.json");
        _storage = new();
    }
    public void Add(Product product)
    {
        var products = ListAll();
        products.Add(product);
        _storage.Write(_path, products);
    }

    public List<Product> ListAll()
    {
        var products = _storage.Read(_path);
        return products;
    }
}
