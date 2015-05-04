using System;

namespace _11_BankData  //11-Bank account data. Basically, I'm creating a bank account
{
    /*  Problem 11. Bank Account Data

    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.  */

    class Program   //Any ideas what to add to this program? I'm stuck :|
    {
        static void Main(string[] args)
        {
            string firstName="Martin";
            string lastName="Ali";
            string userIBAN = "CH93 0076 2011 6238 5295 7";
            long userCreditCardNumber1 = 371449635398431;
            long userCreditCardNumber2 = 36438936438936;
            long userCreditCardNumber3 = 6011016011016011;
            Console.WriteLine("Hello, my name is " + firstName + " " + lastName + "\nMy IBAN is: " + userIBAN + " from a swiss bank\nI have 3 credit cards with the following numbers:\nFirst card is: " + userCreditCardNumber1 + "\nSecond card number is: " + userCreditCardNumber2 + "\nThird card number is: " + userCreditCardNumber3 + "\nHave a nice time hacking :)");
        }
    }
}
