namespace WestcoastBank;

public enum TransactionTypeEnum
{
    Insättning,
    Uttag
}

class Account
{
    // Tillstånd = fields (state)
    public string accountNumber;
    public string firstName;
    public string lastName;
    public int balance = 0;
    public List<Transaction> transactions = [];

    // Metoder = operations
    public void Deposit(int amount)
    {
        balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }
    public void WithDraw(int amount)
    {
        if (balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot!");
        }
        balance -= amount;
        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }
    public string AccountInfo()
    {
        var info = $"AccountNumber: {accountNumber} Name: {firstName} {lastName} Balance: {balance}";
        return info;
    }

    private void AddTransaction(int amount, TransactionTypeEnum transactionType)
    {
        // Skapa en transaktion för uttaget...
        var tran = new Transaction();
        tran.transactionDate = DateTime.Now;
        tran.transactionType = transactionType;
        tran.transactionValue = amount;
        // Addera transaktion till vår lista av transaktioner...
        transactions.Add(tran);
    }
}

public class Transaction
{
    public DateTime transactionDate;
    public int transactionValue;
    public TransactionTypeEnum transactionType;

    public string GetTransactionInfo()
    {
        return $"Date: {transactionDate.ToShortDateString()} Type: {transactionType} Amount: {transactionValue}";
    }
}