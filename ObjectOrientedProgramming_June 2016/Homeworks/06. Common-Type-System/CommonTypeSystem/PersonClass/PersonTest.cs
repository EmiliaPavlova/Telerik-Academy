namespace PersonClass
{
    using System;

    class PersonTest
    {
        static void Main(string[] args)
        {
            var gosho = new Person("Gosho", 30);
            var pesho = new Person("Pesho");

            Console.WriteLine("{0}\n{1}", gosho, pesho);
        }
    }
}
