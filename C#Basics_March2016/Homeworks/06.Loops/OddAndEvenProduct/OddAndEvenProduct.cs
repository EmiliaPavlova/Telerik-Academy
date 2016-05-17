namespace OddAndEvenProduct
{
    using System;

    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            long evenProduct = 1;
            long oddProduct = 1;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(numbers[i]);

                // odd! (starting from 1 for humans
                if (i % 2 == 0)
                {
                    oddProduct *= number;
                }
                // even
                else
                {
                    evenProduct *= number;
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes " + oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}
