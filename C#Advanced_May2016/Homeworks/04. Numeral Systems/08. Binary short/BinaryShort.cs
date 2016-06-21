namespace BinaryShort
{
    using System;

    class BinaryShort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);

            Console.WriteLine(binary.Length >= 16 
                ? binary.Substring(binary.Length - 16) 
                : binary.PadLeft(16, '0'));
            ;
        }
    }
}
