namespace SimpleBank.Entities;

public class BussinessAccount : Account
{
    public double LoanLimit { get; set; }

    public BussinessAccount()
    {
    }

    public BussinessAccount(int number, string holder, double balance, double loanLimit)
        : base(number, holder, balance)
    {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount)
    {
        if (amount <= LoanLimit)
        {
            Balance += amount;
            LoanLimit -= amount;
        }
        else
        {
            Console.WriteLine("It is not possible to loan.");
        }
    }
}