namespace ReverseSentence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseSentence
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var allMarks = new[] {',', ';', '-', ':', '.', '!', '?'};

            Dictionary<int, char> marks = new Dictionary<int, char>();

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].IndexOfAny(allMarks) != -1)
                {
                    marks.Add(i, words[i][words[i].Length - 1]);
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
            }

            // words count should starts from 0, not 1
            int printedWords = -1;

            words.Reverse();
            words.ForEach(x =>
            {
                Console.Write(x);
                printedWords++;
                if (marks.Keys.Any(m => m == printedWords))
                {
                    Console.Write(marks[printedWords].ToString());
                }

                Console.Write(printedWords < words.Count - 1 ? " " : string.Empty);
            });
        }
    }
}
 