namespace AddingPolynomials
{
    using System;
    using System.Linq;

    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] array2 = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] resultArray = AddingPolynomialsArray(array1, array2, n);
            Console.WriteLine(string.Join(" ", resultArray));
        }

        private static int[] AddingPolynomialsArray(int[] array1, int[] array2, int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }
    }
}
