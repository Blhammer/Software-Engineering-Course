using System;

namespace companyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameCompany = Console.ReadLine();
            string address = Console.ReadLine();
            int phoneNumberOffice = int.Parse(Console.ReadLine());
            int fax = int.Parse(Console.ReadLine());
            string website = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int phoneNumberPersonal = int.Parse(Console.ReadLine());

            Console.WriteLine($"The company name: {nameCompany}");
            Console.WriteLine($"Address: {address}.");
            Console.WriteLine($"Office phone number: {phoneNumberOffice}.");
            Console.WriteLine($"Fax: {fax}.");
            Console.WriteLine($"Website: {website}");
            Console.WriteLine($"Manager - full name: {firstName} {lastName}");
            Console.WriteLine($"Personal phone number: {phoneNumberPersonal}");
        }
    }
}
