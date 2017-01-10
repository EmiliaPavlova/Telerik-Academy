namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public abstract class Human : ICommentable
    {
        private string name;

        protected Human(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The discipline name cannot be empty or whitespace");
                }

                this.name = value;
            }
        }

        public abstract void AddComment(Comment comment);
    }
}