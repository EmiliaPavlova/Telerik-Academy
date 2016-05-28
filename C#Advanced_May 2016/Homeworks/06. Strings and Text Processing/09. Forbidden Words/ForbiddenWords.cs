namespace ForbiddenWords
{
    using System;
    using System.Linq;

    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var bannedWords = Console.ReadLine()
               .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            bannedWords.ForEach(x =>
            {
                text = text.Replace(x, new string('*', x.Length));
            });

            Console.WriteLine(text);
        }
    }
}
