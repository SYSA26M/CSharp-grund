namespace WestcoastBank;

public enum TransactionTypeEnum
{
    Insättning,
    Uttag
}

class Account(string accountNo, string fName, string lName, bool hasInterest) // Primary constructor...
{
    // Consts
    const double INTEREST_RATE = 0.05;
    // Fields...
    private readonly bool hasInterest = hasInterest;
    private int _balance;

    // Properties...
    public string AccountNumber { get; } = accountNo;
    public int Balance
    {
        get
        {
            if (hasInterest)
            {
                return Convert.ToInt32(_balance * (1 + INTEREST_RATE));
            }
            else
            {
                return _balance;
            }
        }
        private set { _balance = value; }
    }
    public string FirstName { get; set; } = fName;
    public string LastName { get; set; } = lName;
    public IList<Transaction> Transactions { get; } = [];
    // public IList<Transaction> Transactions { get; } = new List<Transaction>();

    // Metoder = operations
    public void Deposit(int amount)
    {
        Balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }
    public void WithDraw(int amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot!");
        }
        Balance -= amount;
        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }
    public string AccountInfo()
    {
        var info = $"AccountNumber: {AccountNumber} Name: {FirstName} {LastName} Balance: {Balance}";
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
        Transactions.Add(tran);
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