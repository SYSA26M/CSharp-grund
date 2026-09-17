namespace atm;

public class Account(string accountNo)
{
    private int _balance;

    public string AccountNumber { get; } = accountNo;
    public virtual int Balance
    {
        get { return _balance; }
        private set { _balance = value; }
    }
    public IList<Transaction> Transactions { get; } = [];
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

    public override string ToString()
    {
        return $"AccountNumber: {AccountNumber} Balance: {Balance} AccountType: {this.GetType()}";
    }

    private void AddTransaction(int amount, TransactionTypeEnum transactionType)
    {
        var tran = new Transaction();
        tran.transactionDate = DateTime.Now;
        tran.transactionType = transactionType;
        tran.transactionValue = amount;

        Transactions.Add(tran);
    }
}
