namespace SchoolClasses
{
    using System;

    public class Comment
    {
        private string author;
        private string content;

        public Comment(string author, string content)
        {
            this.Author = author;
            this.Content = content;
            this.Date = DateTime.Now;
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The comment cannot be empty or whitespace");
                }

                this.author = value;
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentOutOfRangeException("The content should contains at least 10 symbols");
                }

                this.content = value;
            }
        }

        public DateTime Date { get; }
    }
}