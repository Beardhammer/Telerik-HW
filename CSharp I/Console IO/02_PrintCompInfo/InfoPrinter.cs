using System;
using System.Globalization;
using System.Threading;

namespace _02_PrintCompInfo //Finish this!
{
    internal class InfoPrinter
    {
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please write some details about your company, sir\n");
            while (true)                     //Special "while" used to keep the program running.....forever....spooky
            {
                Console.WriteLine("What is the name of your company?");
                string userCompanyName = Console.ReadLine();

                Console.WriteLine("What is the address of your company?");
                string userCompanyAddress = Console.ReadLine();

                Console.WriteLine("What is the official phone number of your company?");
                string userCompanyPhoneNumber = Console.ReadLine();

                Console.WriteLine("What is the official fax number of your company?");
                string companyFaxNumber = Console.ReadLine();

                Console.WriteLine("What is your company's website?");
                string userWebsite = Console.ReadLine();

                Console.WriteLine("What is your manager's first name?");
                string managerFirstName = Console.ReadLine();

                Console.WriteLine("What's his last name");
                string managerLastName = Console.ReadLine();

                Console.WriteLine("How old is he?");
                byte managerAgeByte;
                string managerAge = Console.ReadLine();

                Console.WriteLine("What's his phone number?");
                string managerPhoneNumber = Console.ReadLine();
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (byte.TryParse(managerAge, out managerAgeByte) ^ string.IsNullOrWhiteSpace(userCompanyName) ^
                    string.IsNullOrWhiteSpace(userCompanyAddress) ^ string.IsNullOrWhiteSpace(userCompanyPhoneNumber) ^
                    string.IsNullOrWhiteSpace(companyFaxNumber) ^ string.IsNullOrWhiteSpace(userWebsite) ^
                    string.IsNullOrWhiteSpace(managerFirstName) ^ string.IsNullOrWhiteSpace(managerLastName) ^
                    string.IsNullOrWhiteSpace(managerPhoneNumber))  //Checks for empty strings or <18 managers....
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    Console.WriteLine("\nCompany name: {0}\nAddress: {1}\nCompany phone number: {2}\nFax number: {3}\nWebsite: {4}\nManager: {5} {6}(Age: {7}, tel. {8})", userCompanyName,userCompanyAddress, userCompanyPhoneNumber, companyFaxNumber, userWebsite, managerFirstName,managerLastName, managerAgeByte, managerPhoneNumber);
                    //{rints all info
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("Invalid Input somewhere. Try again\n");  //error message in case error check returned false
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("\nWanna try again?\n");                      //Program is looped
            }
        }
    }
}
