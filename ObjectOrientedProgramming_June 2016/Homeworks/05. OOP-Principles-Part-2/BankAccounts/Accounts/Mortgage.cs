namespace BankAccounts.Accounts
{
    using Interfaces;

    public class Mortgage : Account, IDeposit
    {
        public Mortgage(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(double months)
        {
            decimal interest = base.CalculateInterest(months);
            switch (this.Customer.CustomerType)
            {
                case CustomerType.Individual:
                    if (months <= 6)
                    {
                        return this.Balance;
                    }
                    else
                    {
                        return base.CalculateInterest(months - 6);
                    }
                case CustomerType.Company:
                    if (months <= 12)
                    {
                        return interest / 2;
                    }
                    else
                    {
                        return base.CalculateInterest(months - 12);
                    }
            }

            return interest;
        }
    }
}