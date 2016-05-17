namespace DecimalToHex
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string hex = string.Empty;

            while (number > 0)
            {
                if (number % 16 < 10)
                {
                    hex = number % 16 + hex;
                }
                else
                {
                    switch (number % 16)
                    {
                        case 10:
                            hex = 'A' + hex;
                            break;
                        case 11:
                            hex = 'B' + hex;
                            break;
                        case 12:
                            hex = 'C' + hex;
                            break;
                        case 13:
                            hex = 'D' + hex;
                            break;
                        case 14:
                            hex = 'E' + hex;
                            break;
                        case 15:
                            hex = 'F' + hex;
                            break;
                        default:
                            break;
                    }
                }

                number /= 16;
            }

            Console.WriteLine(hex);
        }
    }
}
