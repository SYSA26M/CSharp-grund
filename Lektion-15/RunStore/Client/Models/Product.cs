using System;

namespace Client.Models;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string ItemNumber { get; set; }
    public required string Name { get; set; }
    public int Price { get; set; }
}
