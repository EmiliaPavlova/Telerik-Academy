namespace AppearanceCount
{
    using System;
    using System.Linq;

    class AppearanceCount
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            int x = int.Parse(Console.ReadLine());

            int occurrences = CountOccurrences(numbers, x);
            Console.WriteLine(occurrences);
        }

        private static int CountOccurrences(int[] numbers, int x)
        {
            int count = 0;
            foreach (var number in numbers)
            {
                if (number == x)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
