namespace DigitAsWord
{
    using System;

    class DigitAsWord
    {
        static void Main(string[] args)
        {
            int digit;
            string number = string.Empty;
            if (int.TryParse(Console.ReadLine(), out digit))
            {
                switch (digit)
                {
                    case 0:
                        number = "zero";
                        break;
                    case 1:
                        number = "one";
                        break;
                    case 2:
                        number = "two";
                        break;
                    case 3:
                        number = "three";
                        break;
                    case 4:
                        number = "four";
                        break;
                    case 5:
                        number = "five";
                        break;
                    case 6:
                        number = "six";
                        break;
                    case 7:
                        number = "seven";
                        break;
                    case 8:
                        number = "eight";
                        break;
                    case 9:
                        number = "nine";
                        break;
                    default:
                        number = "not a digit";
                        break;
                }

                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
