namespace CompareCharArrays
{
    using System;

    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().ToCharArray();
            char[] array2 = Console.ReadLine().ToCharArray();

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] > array2[i])
                {
                    Console.WriteLine(">");
                    return;
                }
                else if (array1[i] < array2[i])
                {
                    Console.WriteLine("<");
                    return;
                }
            }

            if (array1.Length == array2.Length)
            {
                Console.WriteLine("=");
            }
            else if (array1.Length < array2.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine(">");
            }
        }
    }
}
