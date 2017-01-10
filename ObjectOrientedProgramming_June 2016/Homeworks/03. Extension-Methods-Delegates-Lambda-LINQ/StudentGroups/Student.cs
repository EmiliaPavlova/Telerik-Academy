namespace StudentGroups
{
    using System.Collections.Generic;

    public class Student
    {
        public Student(string firstName, string lastName, string fNumber, string phone, string email, List<double> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FNumber = fNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = new List<double>(marks);
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<double> Marks { get; set; }

        public int GroupNumber { get; set; }
    }
}