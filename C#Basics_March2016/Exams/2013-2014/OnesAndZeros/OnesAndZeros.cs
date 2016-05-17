namespace OnesAndZeros
{
    using System;
    using System.Text;

    class OnesAndZeros
    {
        static string[] zero = new string[] { "###", "#.#", "#.#", "#.#", "###" };
        static string[] one = new string[] { ".#.", "##.", ".#.", ".#.", "###" };
        static int numberOfBits = 16;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            binary = binary.Length < numberOfBits
                ? binary.PadLeft(numberOfBits, '0')
                : binary.Substring(binary.Length - numberOfBits);

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < zero.Length; i++)
            {
                for (int j = 0; j < binary.Length; j++)
                {
                    result.Append((binary[j] == '0' ? zero[i] : one[i]) + ".");
                }

                result.Length--;
                result.AppendLine();
            }

            Console.WriteLine(result);
        }
    }
}
