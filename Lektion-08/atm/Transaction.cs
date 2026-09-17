namespace atm;

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
