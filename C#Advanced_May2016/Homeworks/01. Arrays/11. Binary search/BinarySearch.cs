namespace BinarySearchMatrix
{
    using System;

    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = int.Parse(Console.ReadLine());
            int neededIndex = Array.BinarySearch(myArray, k);

            if (k < myArray[0])
            {
                Console.WriteLine("There is no such number");
            }
            else
            {
                if (neededIndex >= 0)
                {
                    Console.WriteLine(myArray[neededIndex]);
                }
                else
                {
                    Console.WriteLine(myArray[~neededIndex - 1]);
                }
            }
        }
    }
}
