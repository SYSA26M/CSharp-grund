namespace WestcoastCars;


class Program
{
    static void Main()
    {

        var volvo = new Vehicle();
        var ford = new Vehicle();
        var bmw = new Vehicle();


        ford.Break();
        volvo.Break();
        bmw.Break();

        volvo.Make = "Volvo";
        volvo.Model = "EX30";

        ford.Make = "Ford";
        ford.Model = "Fusion";

        bmw.Make = "BMW";
        bmw.Model = "X1";

        Console.WriteLine($"{volvo.Make} {volvo.Model}");
        Console.WriteLine($"{ford.Make} {ford.Model}");
        Console.WriteLine($"{bmw.Make} {bmw.Model}");
        Console.WriteLine("=================================");

        bmw.Model = "i4";

        Console.WriteLine($"{volvo.Make} {volvo.Model}");
        Console.WriteLine($"{ford.Make} {ford.Model}");
        Console.WriteLine($"{bmw.Make} {bmw.Model}");
        Console.WriteLine("=================================");

        /* var volkswagen = volvo;
        volkswagen.Make = "Volkswagen";
        volkswagen.Model = "Tiguan";

        Console.WriteLine($"{volvo.Make} {volvo.Model}");
        Console.WriteLine($"{ford.Make} {ford.Model}");
        Console.WriteLine($"{bmw.Make} {bmw.Model}");
        Console.WriteLine($"{volkswagen.Make} {volkswagen.Model}"); */
    }
}


