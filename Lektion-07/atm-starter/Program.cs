using WestcoastBank;

namespace atm;

class Program
{
    // skapa en kopia/instans av klassen Account...
    static Account account = new Account();
    static string? amount = null;
    static void Main()
    {
        // Påbörjar vår meny...
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Välkommen Westcoast Bank");
        Console.WriteLine("Meny alternativ");
        Console.WriteLine("Ange dina uppgifter och tryck på tangent 'k'");
        Console.WriteLine("För att avsluta programmet tryck på tangenten 'x'");
        Console.WriteLine("För att sätta in pengar tryck på tangenent 'd'");
        Console.WriteLine("För att ta ut pengar tryck på tangenten 'w'");
        Console.WriteLine("För att visa saldot tryck på tangenten 'b'");
        Console.WriteLine("För att visa info tryck på tangenten 'i'");
        Console.WriteLine("------------------------------------------------------------------");

        App();

    }

    static void App()
    {
        try
        {
            while (true)
            {
                var key = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(key) || key == "x")
                {
                    Environment.Exit(0);
                }

                switch (key)
                {
                    case "i":
                        Console.WriteLine(account.AccountInfo());
                        break;
                    case "k":
                        Console.WriteLine("Ange ditt kontonummer följt av förnamn och efternamn");
                        string? info = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(info))
                        {
                            var result = info.Split(" ");
                            if (result.Length != 3)
                            {
                                throw new Exception("Du måste mata in uppgifterna med mellanslag mellan varje ord");
                            }

                            account.accountNumber = result[0];
                            account.firstName = result[1];
                            account.lastName = result[2];
                        }
                        break;
                    case "b":
                        DisplayBalance();
                        break;
                    case "d":
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        amount = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            throw new Exception("Du måste ange ett heltals belopp som du vill sätta in!");
                        }

                        Deposit(amount);

                        break;
                    case "t":
                        DisplayTransactions();
                        break;
                    case "w":
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        amount = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            throw new Exception("Du måste ange ett heltals belopp som du vill ta ut!");
                        }

                        WithDraw(amount);
                        break;
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
            App();
        }
        finally
        {
            Console.WriteLine("Klar!");
        }
    }

    // Enkel metod för att skriva ut saldot...
    static void DisplayBalance()
    {
        Console.WriteLine($"Du har {account.balance} på ditt konto");
    }

    static void DisplayTransactions()
    {
        foreach (var tran in account.transactions)
        {
            Console.WriteLine(tran.GetTransactionInfo());
        }
    }

    static void Deposit(string amount)
    {
        if (!int.TryParse(amount, out int result))
        {
            throw new Exception("Kan inte tolka din inmatning som heltal");
        }
        account.Deposit(result);
    }
    static void WithDraw(string amount)
    {
        if (!int.TryParse(amount, out int result))
        {
            throw new Exception("Tyvärr förstår inte jag vad du menar");
        }
        account.WithDraw(result);
    }
}
