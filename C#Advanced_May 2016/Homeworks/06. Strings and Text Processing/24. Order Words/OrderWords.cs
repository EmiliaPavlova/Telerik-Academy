namespace OrderWords
{
    using System;
    using System.Linq;

    class OrderWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            words.Sort();
            words.ForEach(w =>
            {
                Console.WriteLine(w);
            });
        }
    }
}
