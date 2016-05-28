namespace SubtractingPolynomials
{
    using System;
    using System.Linq;

    class SubtractingPolynomials
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

            int[] resultAddArray = AddingPolynomialsArray(array1, array2, n);
            Console.WriteLine("Adding " + string.Join(" ", resultAddArray));

            int[] resultSubstractArray = SubstractingPolynomialsArray(array1, array2, n);
            Console.WriteLine("Substracting " + string.Join(" ", resultSubstractArray));

            int[] resultMultiplyArray = MultiplyingPolynomialsArray(array1, array2, n);
            Console.WriteLine("Multiplying " + string.Join(" ", resultMultiplyArray));
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

        private static int[] SubstractingPolynomialsArray(int[] array1, int[] array2, int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = array1[i] - array2[i];
            }

            return result;
        }

        private static int[] MultiplyingPolynomialsArray(int[] array1, int[] array2, int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = array1[i] * array2[i];
            }

            return result;
        }
    }
}
