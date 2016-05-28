namespace ParseURL
{
    using System;
    using System.Text.RegularExpressions;

    class ParseURL
    {
        static void Main(string[] args)
        {
            string address = Console.ReadLine();
            //string pattern = @"(https*?):\/\/([^\/]+)(.+)";
            string protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;

            int endindex = 0;
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] != ':')
                {
                    protocol = protocol + address[i];
                }
                else
                {
                    endindex = i;
                    break;
                }
            }

            for (int i = endindex + 3; i < address.Length; i++)
            {
                if (address[i] != '/')
                {
                    server = server + address[i];
                }
                else
                {
                    endindex = i;
                    break;
                }
            }

            for (int i = endindex; i < address.Length; i++)
            {
                resource = resource + address[i];
            }

            Console.WriteLine("[protocol] = {0}\r\n[server] = {1}\r\n[resource] = {2}",
                protocol, server, resource);
        }
    }
}
