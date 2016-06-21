namespace EnglishDigit
{
    using System;

    class EnglishDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = GetLastDigit(number);
            string digitAsWord = GetDigitAsWord(number);
            Console.WriteLine(digitAsWord);
        }

        private static int GetLastDigit(int number)
        {
            return number %= 10;
        }

        private static string GetDigitAsWord(int number)
        {
            string word = string.Empty;
            switch (number)
            {
                case 0: word = "zero"; break;
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
                default: break;
            }

            return word;
        }
    }
}
