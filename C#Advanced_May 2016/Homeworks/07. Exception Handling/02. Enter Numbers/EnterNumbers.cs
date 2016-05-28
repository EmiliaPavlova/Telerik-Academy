namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    class EnterNumbers
    {
        private static int n = 10;

        static void Main(string[] args)
        {
            const int Start = 1;
            const int End = 100;

            var numbers = new List<int>();

            numbers.Add(Start);
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            numbers.Add(End);

            try
            {
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (!ReadNumber(numbers[i - 1], numbers[i]))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }

                Console.WriteLine(string.Join(" < ", numbers));
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        private static bool ReadNumber(int start, int end)
        {
            if (start >= end)
            {
                return false;
            }

            return true;
        }
    }
}