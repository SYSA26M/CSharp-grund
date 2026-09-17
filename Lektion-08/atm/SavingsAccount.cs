namespace atm;

public class SavingsAccount(string accountNo)
    : Account(accountNo)
{
    const double INTEREST_RATE = 0.05;

    public override int Balance
    {
        get { return Convert.ToInt32(base.Balance * (1 + INTEREST_RATE)); }
    }

    public override string ToString()
    {
        return $"AccountNumber: {AccountNumber} Balance: {Balance} InterestRate: {INTEREST_RATE} AccountType: {this.GetType()}";
    }
}
