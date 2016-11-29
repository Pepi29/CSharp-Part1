using System;

namespace _02.CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            if (faxNumber == string.Empty)
            {
                faxNumber = "(no fax)";
            }
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            string phone = Console.ReadLine();
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.Write("Manager: {0} ", firstName);
            Console.Write("{0} ", lastName);
            Console.Write("(age: {0}, ", age);
            Console.WriteLine("tel. {0})", phone);
        }
    }
}
