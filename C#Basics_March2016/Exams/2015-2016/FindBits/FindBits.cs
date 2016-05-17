namespace FindBits
{
    using System;

    class FindBits
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int mask = 31;
            int count = 0;
            int last5BitsOfS = mask & s;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int bit = 0; bit <= 24; bit++)
                {
                    int match = (number >> bit) & mask;
                    if (match == last5BitsOfS)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
