namespace FindSumInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FindSumInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToArray();
            int s = int.Parse(Console.ReadLine());
            var output = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                output.Clear();

                for (int j = i; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                    output.Add(numbers[j]);

                    if (sum == s)
                    {
                        Console.WriteLine(string.Join(", ", output));
                        return;
                    }
                    else if (sum > s)
                    {
                        break;
                    }
                }                
            }

            Console.WriteLine("No such sequence");
        }
    }
}
