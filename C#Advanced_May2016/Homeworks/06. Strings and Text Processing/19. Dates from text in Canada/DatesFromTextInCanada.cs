namespace DatesFromTextInCanada
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MatchCollection dates = Regex.Matches(text, @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b");

            foreach (var date in dates)
            {
                DateTime currDate = DateTime.Parse(date.ToString());
                Console.WriteLine(currDate.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat));
            }
        }
    }
}
