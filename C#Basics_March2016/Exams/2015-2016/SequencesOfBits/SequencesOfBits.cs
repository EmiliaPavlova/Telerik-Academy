namespace SequencesOfBits
{
    using System;
    using System.Text;

    class SequencesOfBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder number = new StringBuilder();
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

                number.Append(result);
            }

            int zerosCount = 0;
            int longestZerosCount = 0;
            int onesCount = 0;
            int longestOnesCount = 0;

            foreach (var bit in number.ToString())
            {
                if (bit == '1')
                {
                    longestOnesCount = Math.Max(++onesCount, longestOnesCount);
                }
                else
                {
                    onesCount = 0;
                }

                if (bit == '0')
                {
                    longestZerosCount = Math.Max(++zerosCount, longestZerosCount);
                }
                else
                {
                    zerosCount = 0;
                }
            }

            Console.WriteLine(longestOnesCount);
            Console.WriteLine(longestZerosCount);
        }
    }
}
