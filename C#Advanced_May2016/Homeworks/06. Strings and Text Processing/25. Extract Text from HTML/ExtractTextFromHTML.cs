namespace ExtractTextFromHTML
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "</html>")
            {
                text.Append(input);
            }

            string titlePattern = @"<title>(.*?)<\/title>";

            Match title = Regex.Match(text.ToString(), titlePattern);
            if (title.Groups[1].Value != string.Empty)
            {
                Console.WriteLine("Title: " + title.Groups[1]);
            }

            string allTextPattern = @"<body>([\s\S]+)<\/body>";
            string tagsPattern = @"(<.+?>)";

            string allText = Regex.Match(text.ToString(), allTextPattern).Groups[1].Value;
            allText = Regex.Replace(allText, "\\s+", " ");
            allText = Regex.Replace(allText, tagsPattern, string.Empty);
            Console.WriteLine("Text: " + allText);
        }
    }
}
