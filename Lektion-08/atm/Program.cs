namespace atm;

class Program
{
    static void Main()
    {
        Account account = new("1111-2222");
        SavingsAccount savingsAccount = new("3333-4444");

        account.Deposit(100);
        savingsAccount.Deposit(100);

        Console.WriteLine(account.ToString());
        Console.WriteLine(savingsAccount.ToString());
    }
}
