namespace SoupScript
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoupScript
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int indexOfBrackets = 0;
            int scope = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                if (line == string.Empty)
                {
                    continue;
                }

                while (line.IndexOf("  ") != -1)
                {
                    line = line.Replace("  ", " ");
                }

                if (line.IndexOf('.') != -1 && line[line.IndexOf('.') + 1] == ' ') // after .
                {
                    line = line.Substring(0, line.IndexOf('.') + 1) + line.Substring(line.IndexOf('.') + 2, line.Length - line.IndexOf('.') - 2);
                }

                if (line.IndexOf('.') != -1 && line[line.IndexOf('.') - 1] == ' ') // before .
                {
                    line = line.Substring(0, line.IndexOf('.') - 1) + line.Substring(line.IndexOf('.'), line.Length - line.IndexOf('.'));
                }

                if (line.IndexOf(',') != -1 && line[line.IndexOf(',') - 1] == ' ')
                {
                    line = line.Substring(0, line.IndexOf(',') - 1) + line.Substring(line.IndexOf(','), line.Length - line.IndexOf(','));
                }

                if (line.IndexOf('!') != -1 && line[line.IndexOf('!') + 1] == ' ')
                {
                    line = line.Substring(0, line.IndexOf('!') + 1) + line.Substring(line.IndexOf('!') + 2, line.Length - line.IndexOf('!') - 2);
                }

                if (line.IndexOf('(') != -1 && line[line.IndexOf('(') - 1] == ' ')
                {
                    line = line.Substring(0, line.IndexOf('(') - 1) + line.Substring(line.IndexOf('('), line.Length - line.IndexOf('('));
                }

                

                if (line.IndexOf("}") != -1)
                {
                    indexOfBrackets--;
                }

                Console.WriteLine(new string(' ', 4 * indexOfBrackets) + line);

                if (line.IndexOf("{") != -1)
                {
                    indexOfBrackets++;
                }
                
            }
        }
    }
}
