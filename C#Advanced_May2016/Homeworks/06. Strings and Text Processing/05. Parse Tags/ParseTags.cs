namespace ParseTags
{
    using System;
    using System.Text.RegularExpressions;

    class ParseTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<upcase>(.*?)<\/upcase>";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                text = text.Replace(match.Groups[0].Value, match.Groups[1].Value.ToUpper());
            }

            Console.WriteLine(text);
        }
    }
}
