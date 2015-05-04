using System;
using System.Globalization;
using System.Threading;

namespace _03_DivideBy7And5
{
    /*  Problem 3. Divide by 7 and 5

    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

Examples:
n 	Divided by 7 and 5?
3 	false
0 	false
5 	false
7 	false
35 	true
140 	true
                */
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Want to check if your number is divisible by both 7 and 5?");
            double userNumber;                  //Number to be checked
            for (int i = 1; i <= 50000; i++)    //Keeps program looping
            {
                string inputValidator = Console.ReadLine();             //Records user input
                if (double.TryParse(inputValidator, out userNumber))    //Checks if user input is numeric
                {
                   if ((userNumber % 5 == 0 & (userNumber % 7 == 0)))   //Checks if number is divisble by both 7 and 5 with AND operator added to avoid unneeded nesting 
                   {
                       Console.WriteLine(userNumber + " is divisible by both 5 and 7");
                       Console.WriteLine("Want to try another one?");
                   }
                   else
                   {
                       Console.WriteLine(userNumber + " is not divisible by both 5 and 7");
                       Console.WriteLine("Want to try another one?");
                   }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");   //Error message in case of invalid input
                }
            }
        }
    }
}
