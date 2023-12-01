namespace Bank;

public class Account
{

    public int Number { get; set; }
    public string Holder { get; set; }

    public double Balance { get; set; }

    public Account(double balance)
    {
        Balance = balance;
    }
    public Account(int number, string holder)
    {
        Number = number;
        Holder = holder;
    }
    public void WithDrawLimit(double amount)
    {
        if (Balance < 0)
        {
            throw new DomainException("Yuo balance is negative");
        }
        Balance -= amount;
        if (Balance < 0)
        {
            throw new DomainException("We authorized this transaction, but you balance is negative now");
        }
        return;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
        return;
    }
}
