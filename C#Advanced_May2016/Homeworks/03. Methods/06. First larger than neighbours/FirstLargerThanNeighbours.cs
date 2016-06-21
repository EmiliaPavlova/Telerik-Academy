namespace FirstLargerThanNeighbours
{
    using System;
    using System.Linq;

    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();

            int index = -1;
            for (int i = 1; i < n - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i + 1] < numbers[i])
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
