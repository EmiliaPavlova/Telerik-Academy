namespace SearchInBits
{
    using System;

    class SearchInBits
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int mask = 15; // 1111
            int last4BitsOfS = s & mask;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int bitIndex = 0; bitIndex <= 26; bitIndex++)
                {
                    int match = (number >> bitIndex) & mask;
                    if (match == last4BitsOfS)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
