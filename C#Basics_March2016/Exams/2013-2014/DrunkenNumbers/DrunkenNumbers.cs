namespace DrunkenNumbers
{
    using System;

    class DrunkenNumbers
    {
        static int beersMitko = 0;
        static int beersVladko = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                CountBeers(int.Parse(Console.ReadLine()));
            }

            if (beersMitko > beersVladko)
            {
                Console.WriteLine("M {0}", beersMitko - beersVladko);
            }
            else if (beersVladko > beersMitko)
            {
                Console.WriteLine("V {0}", beersVladko - beersMitko);
            }
            else
            {
                Console.WriteLine("No {0}", beersMitko + beersVladko);
            }
        }

        public static void CountBeers(int number)
        {
            string digits = Math.Abs(number).ToString();

            for (int j = 0; j < digits.Length; j++)
            {
                if (j < digits.Length / 2)
                    beersMitko += digits[j] - '0';
                else
                    beersVladko += digits[j] - '0';
            }

            if (digits.Length % 2 != 0)
                beersMitko += digits[digits.Length / 2] - '0';
        }
    }
}
