namespace BankAccounts.Accounts
{
    using System;
    using Interfaces;

    public class Deposit : Account, IDeposit, IWithdraw
    {
        public Deposit(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal money)
        {
            if (money > this.Balance)
            {
                throw new ArgumentException("Not enough money in the account.");
            }
            this.Balance -= money;
        }

        public override decimal CalculateInterest(double months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}