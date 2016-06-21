namespace FrequentNumber
{
    using System;
    using System.Linq;

    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var groupedArray = from numbers in array
                group numbers by numbers
                into groupedNumbers
                select new {Number = groupedNumbers.Key, Freq = groupedNumbers.Count()};
            groupedArray = groupedArray.OrderByDescending(x => x.Freq);
            
            Console.WriteLine("{0} ({1} times)", groupedArray.First().Number, groupedArray.First().Freq);
        }
    }
}
