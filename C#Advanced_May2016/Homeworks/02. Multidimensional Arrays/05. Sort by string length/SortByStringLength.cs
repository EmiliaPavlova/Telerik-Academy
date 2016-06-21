namespace SortByStringLength
{
    using System;
    using System.Linq;

    class SortByStringLength
    {
        static void Main(string[] args)
        {
            string[] unsortedStrings = { "a", "aaaaa", "aaaawasdawd", "a", "12355asdf", "wdasdwe" };

            var sortedArray = unsortedStrings.OrderBy(uStrings => uStrings.Length);
            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
