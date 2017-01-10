namespace BankAccounts.Accounts
{
    using Interfaces;

    public class Loan : Account, IDeposit
    {
        public Loan(ICustomer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(double months)
        {
            decimal result = base.CalculateInterest(months);
            switch (this.Customer.CustomerType)
            {
                case CustomerType.Individual:
                    if (months <= 3)
                    {
                        result = this.Balance;
                    }
                    else
                    {
                        return base.CalculateInterest(months - 3);
                    }
                    break;
                case CustomerType.Company:
                    if (months <= 2)
                    {
                        result = this.Balance;
                    }
                    else
                    {
                        return base.CalculateInterest(months - 2);
                    }
                    break;
            }

            return result;
        }
    }
}