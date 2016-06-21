namespace WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class WordsCount
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, int> distinct = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!distinct.ContainsKey(word))
                {
                    distinct.Add(word, 1);
                }
                else
                {
                    distinct[word]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in distinct)
            {
                Console.WriteLine(int.Parse(pair.Value.ToString()) == 1
                    ? "{0} - {1} time"
                    : "{0} - {1} times", pair.Key, pair.Value);
            }
        }
    }
}
