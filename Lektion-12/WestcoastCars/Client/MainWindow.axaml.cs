using System;
using Avalonia.Controls;

namespace Client;

public partial class MainWindow : Window
{
    public Vehicle Vehicle { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        Vehicle = new();
        Make.Text = Vehicle.Manufacturer;
    }

    private void ChangeMake_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Vehicle.Manufacturer = NewManufacturer.Text!;
        Make.Text = Vehicle.Manufacturer;
    }
}