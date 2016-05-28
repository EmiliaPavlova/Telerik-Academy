namespace GetLargestNumber
{
    using System;
    using System.Linq;

    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[2];
            int max = GetMax(a, b);
            max = GetMax(max, c);
            Console.WriteLine(max);
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
