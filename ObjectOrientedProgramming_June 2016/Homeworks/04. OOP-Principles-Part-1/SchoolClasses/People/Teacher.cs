namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : Human
    {
        private List<Comment> comments;

        public Teacher(string name) : base(name)
        {
            this.Discipline = new List<Discipline>();
            this.comments = new List<Comment>();
        }

        public List<Discipline> Discipline { get; set; }

        public override void AddComment(Comment comment)
        {
            this.comments.Add(comment);
        }
    }
}