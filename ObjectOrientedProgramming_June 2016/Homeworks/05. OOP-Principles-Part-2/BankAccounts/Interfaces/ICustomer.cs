namespace BankAccounts.Interfaces
{
    public interface ICustomer
    {
        string Name { get; } 

        CustomerType CustomerType { get; }
    }
}