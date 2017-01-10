namespace BankAccounts
{
    using System;
    using Interfaces;

    public class Customer : ICustomer
    {
        private string name;

        public Customer(string name, CustomerType customerType)
        {
            this.Name = name;
            this.CustomerType = customerType;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Customer's name cannot be empty.");
                }

                this.name = value;
            }
        }

        public CustomerType CustomerType { get; }
    }
}