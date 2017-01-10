namespace BankAccounts.Interfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; set; }

        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        decimal CalculateInterest(double months);
    }
}