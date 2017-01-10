namespace DancingMoves
{
    using System;
    using System.Linq;

    class DancingMoves
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            int round = 0;
            int position = 0;
            long sum = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                string[] line = input.Split(' ');
                int times = int.Parse(line[0]);
                string direction = line[1];
                int step = int.Parse(line[2]);

                round++;

                for (int i = 0; i < times; i++)
                {
                    switch (direction)
                    {
                        case "right":
                            while (position + step > array.Count - 1)
                            {
                                position -= (array.Count);
                            }

                            position += step;
                            sum += array[position];
                            break;
                        case "left":
                            while (position - step < 0)
                            {
                                position += array.Count;
                            }

                            position -= step;
                            sum += array[position];
                            break;
                        default:
                            break;
                    }
                }

                //Console.WriteLine(sum);
            }

            double result = (double) sum / round;
            Console.WriteLine("{0:F1}", result);
        }
    }
}
