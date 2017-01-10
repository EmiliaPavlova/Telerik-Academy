namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using Accounts;
    using Interfaces;

    class StartUp
    {
        static void Main(string[] args)
        {
            var accounts = new List<IAccount>()
            {
                new Deposit(new Customer("Ivan Ivanov", CustomerType.Individual), 10000.00m, 0.07m),
                new Deposit(new Customer("Peter Petrov", CustomerType.Individual), 20000.00m, 0.07m),
                new Deposit(new Customer("Maria Ivanov", CustomerType.Individual), 100000.00m, 1.1m),

                new Loan(new Customer("Ivan Ivanov", CustomerType.Individual), 2000.00m, 0.12m),
                new Loan(new Customer("Game Bar", CustomerType.Company), 50000.00m, 0.5m),

                new Mortgage(new Customer("SoftUni", CustomerType.Company), 100000m, 1.2m),
                new Mortgage(new Customer("XS Software", CustomerType.Company), 100000m, 1.1m)
            };

            foreach (var account in accounts)
            {
                var output = string.Format("{0} - Name: {1}, {2}, account balance: {3}",
                    account.GetType().Name, account.Customer.Name, account.Customer.CustomerType, account.Balance);
                Console.WriteLine(output);
            }
        }
    }
}
