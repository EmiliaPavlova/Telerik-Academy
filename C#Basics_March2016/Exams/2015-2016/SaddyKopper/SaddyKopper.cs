namespace SaddyKopper
{
    using System;
    using System.Numerics;

    class SaddyKopper
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            int transformations = 0;
            bool isOneDigit = false;
            BigInteger product = 1;

            while (!isOneDigit && transformations < 10)
            {
                number = number.Remove(number.Length - 1);
                int sum = 0;
                product = 1;
                int position = 0;

                foreach (var digit in number)
                {
                    if (position % 2 != 0)
                    {
                        sum += (digit - '0');
                    }
                    
                    product *= sum;
                    position++;
                }

                transformations++;
                number = product.ToString();
                if (number.Length == 1)
                {
                    isOneDigit = true;
                }
            }

            if (transformations < 10)
            {
                Console.WriteLine(transformations);
            }

            Console.WriteLine(product);
        }
    }
}
