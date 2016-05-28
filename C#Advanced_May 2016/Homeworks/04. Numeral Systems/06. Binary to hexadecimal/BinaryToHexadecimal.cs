namespace BinaryToHexadecimal
{
    using System;

    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            char[] hexChars = "0123456789ABCDEF".ToCharArray();
            string currentBinary = string.Empty;
            string hex = string.Empty;
            int currentHex = 0;

            while (binary.Length > 0)
            {
                if (binary.Length >= 4)
                {
                    currentBinary = binary.Substring(binary.Length - 4, 4);
                    binary = binary.Remove(binary.Length - 4, 4);
                }
                else
                {
                    currentBinary = binary;
                    binary = string.Empty;
                }

                currentHex = 0;

                for (int i = 0; i < currentBinary.Length; i++)
                {
                    currentHex += (int) Math.Pow(2, i) * int.Parse(currentBinary[currentBinary.Length - 1 - i].ToString());
                }

                hex = hexChars[currentHex] + hex;
            }

            Console.WriteLine(hex);
        }
    }
}
