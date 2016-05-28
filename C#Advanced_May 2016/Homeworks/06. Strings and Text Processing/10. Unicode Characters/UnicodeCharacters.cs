namespace UnicodeCharacters
{
    using System;
    using System.Linq;

    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToList();

            input.ForEach(x =>
            {
                Console.Write("\\u" + ((int)x).ToString("X4"));
            });
        }
    }
}
