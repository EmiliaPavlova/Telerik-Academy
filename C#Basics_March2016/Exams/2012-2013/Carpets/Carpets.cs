namespace Carpets
{
    using System;
    using System.Text;

    class Carpets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = (n - 2) / 2;
            char right = '/';
            char left = '\\';
            char empty = ' ';

            for (int i = 0; i < n / 2; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(new string('.', dots));
                while (sb.Length < n / 2)
                {
                    sb.Append(right);
                    if (sb.Length < n / 2)
                    {
                        sb.Append(empty);
                    }
                }

                // second quorter
                if (i % 2 != 0)
                {
                    sb.Append(empty);
                }

                while (sb.Length + dots < n)
                {
                    sb.Append(left);
                    if (sb.Length + dots < n)
                    {
                        sb.Append(empty);
                    }
                }

                sb.Append(new string('.', dots));
                dots--;
                Console.WriteLine(sb);
            }

            // third quorter
            dots = 0;
            for (int j = 0; j < n / 2; j++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(new string('.', dots));
                while (sb.Length < n / 2)
                {
                    sb.Append(left);
                    if (sb.Length < n / 2)
                    {
                        sb.Append(empty);
                    }
                }

                //last quorter
                if ((n / 2 - dots) % 2 == 0)
                {
                    sb.Append(empty);
                }

                while (sb.Length + dots < n)
                {
                    sb.Append(right);
                    if (sb.Length + dots < n)
                    {
                        sb.Append(empty);
                    }
                }

                sb.Append(new string('.', dots));
                dots++;
                Console.WriteLine(sb);
            }
        }
    }
}
