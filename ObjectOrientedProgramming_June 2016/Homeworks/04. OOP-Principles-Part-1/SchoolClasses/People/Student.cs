namespace SchoolClasses
{
    using System.Collections.Generic;
    using Interfaces;

    public class Student : Human
    {
        private string uniqueNumber;
        private List<Comment> comments;

        public Student(string name, string uniqueNumber) : base(name)
        {
            this.UniqueNumber = uniqueNumber;
            this.comments = new List<Comment>();
        }

        public string UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            protected set
            {
                this.uniqueNumber = value;
            }
        }

        public override void AddComment(Comment comment)
        {
            this.comments.Add(comment);
        }
    }
}