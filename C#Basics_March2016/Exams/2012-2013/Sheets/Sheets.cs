namespace Sheets
{
    using System;
    using System.Linq;

    class Sheets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sheets = new string[] {"A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10"};
            int index = 10;

            while (n > 1)
            {
                if (n - Math.Pow(2, index) >= 0)
                {
                    sheets = sheets.Where(s => s != "A" + (10 - index)).ToArray();
                    n -= (int)Math.Pow(2, index);
                }

                index--;
            }

            if (n == 1)
            {
                sheets = sheets.Where(s => s != "A10").ToArray();
            }
            
            Console.WriteLine(string.Join("\r\n", sheets));
        }
    }
}
