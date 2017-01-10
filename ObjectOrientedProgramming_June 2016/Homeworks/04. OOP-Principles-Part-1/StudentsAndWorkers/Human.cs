namespace StudentsAndWorkers
{
    using System;
    using System.Text.RegularExpressions;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (isValidName(value))
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (isValidName(value))
                {
                    this.lastName = value;
                }
            }
        }

        private bool isValidName(string name)
        {
            if (Regex.IsMatch(name, "[A-Za-z]{2,}"))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Invalid name format");
            }
        }

        public override string ToString()
        {
            string output = string.Format("My name is {0} {1} and I'm a {2}", this.firstName, this.lastName, GetType().Name);
            return output.ToString();
        }
    }
}