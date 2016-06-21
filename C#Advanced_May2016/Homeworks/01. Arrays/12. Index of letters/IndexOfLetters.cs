namespace IndexOfLetters
{
    using System;

    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            char[] word = Console.ReadLine().ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(Array.IndexOf(alphabet, word[i]));
            }
        }
    }
}
