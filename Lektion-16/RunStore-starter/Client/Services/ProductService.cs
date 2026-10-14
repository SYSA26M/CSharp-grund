using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class ProductService : IProductService
{
    public List<Product> ListAll()
    {
        return [
            new(){ItemNumber="1000", Name="Dojan 1",Price=1500},
            new(){ItemNumber="1001", Name="Tröja 1",Price=495},
            new(){ItemNumber="1002", Name="Jacka 1",Price=2500}
        ];
    }
}
