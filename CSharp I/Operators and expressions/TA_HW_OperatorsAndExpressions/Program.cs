using System;
using System.Globalization;
using System.Threading;

namespace TA_HW_OperatorsAndExpressions
{
    /*
    Write an expression that checks if given integer is odd or even.

Examples:
n 	Odd?
3 	true
2 	false
-2 	false
-1 	true
0 	false   
               */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Want to check if Thine number is odd or even?");
            for (var i = 1; i <= 50000; i++)                             //Keeps program repeating itself
            {
                var inputValidator = Console.ReadLine();                 //Used in input validation
                double numberForCheck;                                   //Also used in input validation

                if (double.TryParse(inputValidator, out numberForCheck)) //Checks if input is numeric
                {
                    if (numberForCheck%2 == 0)                           //Checks if number is divisible by 2
                    {
                        Console.WriteLine("Thine number is even");
                        Console.WriteLine("Want to try again?");
                    }
                    else
                    {
                        Console.WriteLine("Thine number is odd");
                        Console.WriteLine("Want to try again?");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again with a valid number");
                        //Error message in case of invalid input
                }
            }
        }
    }
}
