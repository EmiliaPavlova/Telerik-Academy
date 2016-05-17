namespace TribonacciTriangle
{
    using System;

    class TribonacciTriangle
    {
        static void Main(string[] args)
        {
            long trib1 = long.Parse(Console.ReadLine());
            long trib2 = long.Parse(Console.ReadLine());
            long trib3 = long.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine(trib1);
            Console.WriteLine(trib2 + " " + trib3);

            for (int row = 2; row < lines; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    long tribNumber = trib1 + trib2 + trib3;
                    Console.Write(tribNumber + " ");

                    trib1 = trib2;
                    trib2 = trib3;
                    trib3 = tribNumber;
                }

                Console.WriteLine();
            }
        }
    }
}
