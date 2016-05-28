namespace SeriesOfLetters
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder distinctLetters = new StringBuilder();
            distinctLetters.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                {
                    distinctLetters.Append(input[i]);
                }
            }

            Console.WriteLine(distinctLetters);

            // Regex
            //foreach (char ch in input)
            //{
            //    Regex equalChars = new Regex(ch + "+");
            //    input = equalChars.Replace(input, ch.ToString());
            //}

            //Console.WriteLine(input);
        }
    }
}
