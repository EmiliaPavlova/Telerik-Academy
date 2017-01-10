namespace StudentClass.Models
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    public class Student : ICloneable, IComparable<Student>
    {
        private string[] Names;

        public Student(string name, string adress, string phone, string email, string ssn, byte course, Universities uni, Faculties fac, Specialties spec)
        {
            Names = name.Split(' ');
            this.Adress = adress;
            this.Phone = phone;
            this.Email = email;
            this.SSN = ssn;
            this.Course = course;
            this.University = uni;
            this.Faculty = fac;
            this.Specialty = spec;
        }

        public string FirstName => this.Names[0];
        public string MiddleName => this.Names[1];
        public string LastName => this.Names[2];
        public string WholeName => $"{this.FirstName} {this.MiddleName} {this.LastName}";
        public string Adress { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string SSN { get; private set; }
        public byte Course { get; private set; }
        public Universities University { get; private set; }
        public Faculties Faculty { get; private set; }
        public Specialties Specialty { get; private set; }

        public object Clone()
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, this); 
            stream.Position = 0;
            Object cloned = formatter.Deserialize(stream);
            stream.Close();

            return cloned;
        }

        public int CompareTo(Student other)
        {
            int comparison = this.WholeName.CompareTo(other.WholeName);
            if (comparison == 0)
                return this.SSN.CompareTo(other.SSN);

            return comparison;
        }

        public override bool Equals(Object s)
        {
            var rhs = s as Student;

            if (s == null)
                return false;

            return this.FirstName == rhs.FirstName &&
                   this.MiddleName == rhs.MiddleName &&
                   this.LastName == rhs.LastName &&
                   this.Adress == rhs.Adress &&
                   this.Course == rhs.Course &&
                   this.Email == rhs.Email &&
                   this.Faculty == rhs.Faculty &&
                   this.Phone == rhs.Phone &&
                   this.SSN == rhs.SSN &&
                   this.University == rhs.University &&
                   this.Specialty == rhs.Specialty;
        }

        public static bool operator ==(Student lhs, Student rhs)
        {
            return ReferenceEquals(lhs, rhs) || lhs.Equals(rhs);
        }

        public static bool operator !=(Student lhs, Student rhs)
        {
            return !(lhs == rhs);
        }

        public override string ToString()
        {
            return $"Student {this.WholeName}, {this.SSN}, {this.University}.";
        }

        public override int GetHashCode()
        {
            int hash = 29;
            int hashMultiplier = 11;

            unchecked
            {
                hash = hash * hashMultiplier + $"{this.FirstName} {this.MiddleName} {this.LastName}".GetHashCode();
                hash = hash * hashMultiplier + Adress.GetHashCode();
                hash = hash * hashMultiplier + Course.GetHashCode();
                hash = hash * hashMultiplier + Email.GetHashCode();
                hash = hash * hashMultiplier + Faculty.GetHashCode();
                hash = hash * hashMultiplier + Phone.GetHashCode();
                hash = hash * hashMultiplier + SSN.GetHashCode();
                hash = hash * hashMultiplier + University.GetHashCode();
                hash = hash * hashMultiplier + Specialty.GetHashCode();
            }

            return hash;
        }
    }
}