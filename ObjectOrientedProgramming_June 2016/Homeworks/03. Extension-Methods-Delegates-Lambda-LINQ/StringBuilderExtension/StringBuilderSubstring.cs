namespace StringBuilderExtension
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder substring = new StringBuilder();

            if (index + length - 1 >= input.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }

            int endIndex = index + length;

            for (int i = index; i < endIndex; i++)
            {
                substring.Append(input[i]);
            }

            return substring;
        }

        public static StringBuilder Substring(this StringBuilder input, int startIndex)
        {
            StringBuilder substring = new StringBuilder();

            if (startIndex < 0 || startIndex >= input.Length)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }

            for (int i = startIndex; i < input.Length; i++)
            {
                substring.Append(input[i]);
            }

            return substring;
        }
    }
}