namespace LongestString
{
    using System;
    using System.Linq;

    //using System.Linq;

    class LongestString
    {
        static void Main(string[] args)
        {
            string[] strings = new[]
            {
                "Write a program to return the string with maximum length from an array of strings.",
                "Write a program.",
                "Write a program to return the string with maximum length from an array of strings. - The longest one!",
                "Write a program to return the string with maximum length from an array."
            };

            var maxLength = strings.Max(s => s.Length);
            var longestString = strings.Where(s => s.Length == maxLength);
            foreach (var str in longestString)
            {
                Console.WriteLine(str);
            }
        }
    }
}
