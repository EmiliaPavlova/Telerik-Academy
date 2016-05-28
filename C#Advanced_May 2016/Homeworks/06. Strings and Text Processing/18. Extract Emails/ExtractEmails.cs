namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\s([a-zA-Z0-9][\w\.\-]+@[a-zA-Z0-9][a-zA-Z\-\.]+\.[a-zA-Z]+)";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
