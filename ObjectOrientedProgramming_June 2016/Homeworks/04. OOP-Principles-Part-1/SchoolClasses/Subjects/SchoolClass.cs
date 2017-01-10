namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class SchoolClass : ICommentable
    {
        private string identifier;
        private List<Comment> comments;

        public SchoolClass(string identifier)
        {
            this.Identifier = identifier;
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
            this.comments = new List<Comment>();
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            protected set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Identifier cannot be null or white space");
                }

                this.identifier = value;
            }
        }

        public HashSet<Student> Students { get; set; }

        public HashSet<Teacher> Teachers { get; set; }

        public void AddComment(Comment comment)
        {
            this.comments.Add(comment);
        }
    }
}