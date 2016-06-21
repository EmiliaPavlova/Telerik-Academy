namespace ExtractSentences
{
    using System;
    using System.Linq;

    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            var sentences = input
                .Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            char[] separators = ExtractSeparators(input);

            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (word == words[i])
                    {
                        Console.Write(sentence.Trim() + ". ");
                        break;
                    }
                }
            }
        }

        private static char[] ExtractSeparators(string input)
        {
            char[] separators = input
                .Where(c => !char.IsLetter(c))
                .Distinct()
                .ToArray();

            return separators;
        }
    }
}
