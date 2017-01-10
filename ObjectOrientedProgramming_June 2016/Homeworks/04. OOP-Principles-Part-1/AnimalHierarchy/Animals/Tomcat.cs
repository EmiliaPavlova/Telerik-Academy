namespace AnimalHierarchy.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.male)
        {
        }

        public override string ProduceSound()
        {
            return "Miau miau";
        }
    }
}