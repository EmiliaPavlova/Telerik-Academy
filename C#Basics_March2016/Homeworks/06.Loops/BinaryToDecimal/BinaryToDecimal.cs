namespace BinaryToDecimal
{
    using System;

    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] != '0')
                {
                    sum += Math.Pow(2, i);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
