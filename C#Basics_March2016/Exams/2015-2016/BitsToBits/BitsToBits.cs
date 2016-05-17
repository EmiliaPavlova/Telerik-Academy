namespace BitsToBits
{
    using System;
    using System.Text;

    class BitsToBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder binary = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string result = Convert.ToString(num, 2);
                if (result.Length < 30)
                {
                    result = result.PadLeft(30, '0');
                }

                if (result.Length > 30)
                {
                    result = result.Substring(result.Length - 30);
                }

                binary.Append(result);
            }

            int longestCountZeros = 0;
            int currentCountZeros = 0;
            int longestCountOnes = 0;
            int currentCountOnes = 0;

            foreach (var bit in binary.ToString())
            {
                if (bit == '0')
                {
                    longestCountZeros = Math.Max(++currentCountZeros, longestCountZeros);
                }
                else
                {
                    currentCountZeros = 0;
                }

                if (bit == '1')
                {
                    longestCountOnes = Math.Max(++currentCountOnes, longestCountOnes);
                }
                else
                {
                    currentCountOnes = 0;
                }
            }

            Console.WriteLine(longestCountZeros);
            Console.WriteLine(longestCountOnes);
        }
    }
}
