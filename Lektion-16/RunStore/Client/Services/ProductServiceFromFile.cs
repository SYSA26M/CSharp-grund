using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class ProductServiceFromFile : IProductService
{
    public void Add(Product product)
    {
        throw new NotImplementedException();
    }

    public List<Product> ListAll()
    {
        var storage = new Storage<Product>();
        var path = string.Concat(Environment.CurrentDirectory, "/Data/products.json");
        var products = storage.Read(path);

        return products;
    }
}
