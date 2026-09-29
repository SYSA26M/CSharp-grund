using System;
using Avalonia.Controls;

namespace Client;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Du klickade på mig!");
    }

    private void SaveButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Jag sparar!");
    }

    private void Updatera(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Jag uppdaterar!");
    }
}