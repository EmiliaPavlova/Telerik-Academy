namespace ReadFileContents
{
    using System;
    using System.IO;

    class ReadFileContents
    {
        static void Main(string[] args)
        {
            using (StreamReader textReader = new StreamReader("../../text.txt"))
            {
                var text = textReader.ReadToEnd();
                Console.WriteLine(text);
            }
        }
    }
}
