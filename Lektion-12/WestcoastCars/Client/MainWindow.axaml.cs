using System;
using Avalonia.Controls;

namespace Client;

public partial class MainWindow : Window
{
    public string Manufacturer { get; set; } = "Kia";
    public MainWindow()
    {
        InitializeComponent();
        Make.Text = Manufacturer;
    }

    private void ChangeMake_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Manufacturer = "Mercedes";
        Make.Text = Manufacturer;
    }
}