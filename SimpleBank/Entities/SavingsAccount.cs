namespace SimpleBank.Entities;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount()
    {
    }

    public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalace()
    {
        Balance += Balance * InterestRate;
    }
}