namespace Sub_stringInText
{
    using System;

    class SubStringInText
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int count = 0;
            int index = text.IndexOf(pattern);

            while (index != -1)
            {
                index = text.IndexOf(pattern, index + 1);
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
