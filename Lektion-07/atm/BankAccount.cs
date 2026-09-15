namespace WestcoastBank;

public enum TransactionTypeEnum
{
    Insättning,
    Uttag
}

class Account(string accountNo, string fName, string lName) // Primary constructor...
{

    // Tillstånd = fields (state)
    private readonly string _accountNumber = accountNo;
    private string _firstName = fName;
    private string _lastName = lName;
    private int _balance = 0;
    private List<Transaction> _transactions = [];

    // Properties...
    public string AccountNumber
    {
        get { return _accountNumber; }
    }
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    public int Balance
    {
        get { return _balance; }
    }
    public List<Transaction> Transactions
    {
        get { return _transactions; }
    }

    // Metoder = operations
    public void Deposit(int amount)
    {
        _balance += amount;
        AddTransaction(amount, TransactionTypeEnum.Insättning);
    }
    public void WithDraw(int amount)
    {
        if (_balance < amount)
        {
            throw new Exception("Du har inte tillräckligt på kontot!");
        }
        _balance -= amount;
        AddTransaction(amount, TransactionTypeEnum.Uttag);
    }
    public string AccountInfo()
    {
        var info = $"AccountNumber: {_accountNumber} Name: {_firstName} {_lastName} Balance: {_balance}";
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
        _transactions.Add(tran);
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