namespace AnimalHierarchy.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.female)
        {
        }

        public override string ProduceSound()
        {
            return "Murrrrr";
        }
    }
}