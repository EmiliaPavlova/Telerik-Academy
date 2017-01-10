namespace PersonClass
{
    public class Person
    {
        private string name;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int? Age { get; private set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, age: {(this.Age == null ? "N/A" : this.Age.ToString())}";
        }
    }
}