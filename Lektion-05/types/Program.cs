namespace types;

public class Vehicle
{
    public string manufacturer = "";
    public string model = "";
    public int modelYear;
    public int mileage;

    public void Accelerate()
    {
        Console.WriteLine("Jag gasar!!!");
    }
}

public struct Customer
{
    public string firstName = "";
    public string lastName = "";

    public Customer()
    {
    }

    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }
}

public struct Point
{
    public int x;
    public int y;
}

public record Product
{
    public string itemNumber = "";
    public string name = "";
    public int numberInStock;
}

class Program
{
    static void Main(string[] args)
    {
        var volvo = new Vehicle();
        volvo.model = "XC40";
        volvo.manufacturer = "Volvo";
        volvo.modelYear = 2018;
        volvo.mileage = 2500000;
        volvo.Accelerate();

        var ford = new Vehicle();
        ford.model = "MACH-E";
        ford.manufacturer = "Ford";
        ford.modelYear = 2022;
        ford.mileage = 100000;
        ford.Accelerate();

        Console.WriteLine(volvo.model);
        Console.WriteLine(ford.model);

        volvo.model = "Amazon";

        Console.WriteLine(volvo.model);
        Console.WriteLine(ford.model);

        var michael = new Customer();
        michael.firstName = "Michael";
        michael.lastName = "Gustavsson";

        var product = new Product();
        product.itemNumber = "AAA-1";
        product.name = "Produkt 1";
        product.numberInStock = 10;
    }
}

