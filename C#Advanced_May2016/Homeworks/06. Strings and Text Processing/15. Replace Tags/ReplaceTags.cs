namespace ReplaceTags
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = Regex.Replace(input, @"<a\s*href\s*=""(.*?)"">([\s\S]*?)<\/a>", "[$2]($1)");
            Console.WriteLine(output);
        } 
    }
}
