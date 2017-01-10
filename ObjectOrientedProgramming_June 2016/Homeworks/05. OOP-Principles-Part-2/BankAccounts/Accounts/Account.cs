namespace BankAccounts.Accounts
{
    using Interfaces;

    public abstract class Account : IAccount
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public virtual decimal CalculateInterest(double months)
        {
            decimal interest = (decimal)months * this.InterestRate;
            return interest;
        }

        public virtual void Deposit(decimal money)
        {
            this.Balance += money;
        }
    }
}