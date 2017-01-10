namespace Generics
{
    using System;
    using Attributes;

    class GenericListMain
    {
        static void Main(string[] args)
        {
            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (var version in allAttributes)
            {
                if (version is CurrVersion)
                {
                    Console.WriteLine(version);
                }
            }
            Console.WriteLine(new string('/', 70));
            GenericList<int> myList = new GenericList<int>();
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(2);
            myList.Add(1);
            myList.Add(17);
            myList.Add(1);
            myList.Add(7);
            myList.Add(4);
            myList.Add(4);
            myList.Add(4);
            myList.Add(-4);
            myList.Add(7);
            myList.Add(1);
            Console.WriteLine("Max in List: {0}", myList.Max());
            Console.WriteLine("Min in List: {0}", myList.Min());
            Console.WriteLine("List: {0}", myList[7]);
            myList.Remove(7);
            myList[0] = 10;
            myList.Sort();
            Console.WriteLine("Sorted List: {0}", myList);
            myList.Reverse();
            Console.WriteLine("Reversed List: {0}", myList);
            Console.WriteLine(myList.Contains(1000));

            try
            {
                Console.WriteLine(myList[34]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
