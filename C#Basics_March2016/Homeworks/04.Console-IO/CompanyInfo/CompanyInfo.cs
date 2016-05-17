namespace CompanyInfo
{
    using System;

    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            if (faxNumber == string.Empty)
            {
                faxNumber = "(no fax)";
            }

            Console.WriteLine("{0}\r\nAddress: {1}\r\nTel. {2}\r\nFax: {3}\nWeb site: {4}\r\nManager: {5} {6} (age: {7}, tel. {8})",
                              companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, age, managerPhone);
            
        }
    }
}
