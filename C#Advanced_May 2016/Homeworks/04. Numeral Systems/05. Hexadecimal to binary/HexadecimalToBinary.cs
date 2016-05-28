namespace HexadecimalToBinary
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    class HexadecimalToBinary
    {
        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'A', "1010" },
            { 'B', "1011" },
            { 'C', "1100" },
            { 'D', "1101" },
            { 'E', "1110" },
            { 'F', "1111" }
        };

        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            StringBuilder binary = new StringBuilder();

            foreach (char hexDigit in hex)
            {
                binary.Append(hexCharacterToBinary[hexDigit]);
            }

            Console.WriteLine(BigInteger.Parse(binary.ToString()));
        }
    }
}
