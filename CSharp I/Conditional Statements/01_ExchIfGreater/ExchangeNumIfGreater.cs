using System;
using System.Globalization;
using System.Threading;

namespace _01_ExchIfGreater
{
    /*Problem 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

Examples:
a 	b 	result
5 	2 	2 5
3 	4 	3 4
5.5 	4.5 	4.5 5.5                 */
    class ExchangeNumIfGreater  //Try without if statements?
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter your first number");
            while (true)    //Keeps program repeating forever
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                double firstNum = 0;    //Used in input validation
                double secondNum = 0;

                string firstNumValidator = Console.ReadLine();
                Console.WriteLine("Please enter your second number");
                string secondNumValidator = Console.ReadLine();

                if (double.TryParse(firstNumValidator, out firstNum) && double.TryParse(secondNumValidator, out secondNum))    //Input is checked for non-numeric elements
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    Console.WriteLine("The values you entered are: \nFirst number: " + firstNum + "\nSecond number: " + secondNum + "\n");  //Prints values the user has entered before any action is taken
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (firstNum > secondNum)   //Case first number is bigger than second
                    {
                        double temp = firstNum;
                        firstNum = secondNum;
                        secondNum = temp;
                        Console.WriteLine("First number is bigger, therefore values are swapped\nFirst number: " + firstNum + "\nSecond number is: " + secondNum);
                    }
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else if (secondNum > firstNum)    //Case second number is bigger than first
                    {
                        Console.WriteLine("First number is not bigger, therefore no values are swapped");

                    }
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else   //Case else. Most likely equal numbers
                    {
                        Console.WriteLine("Your numbers "+firstNum+" and "+secondNum+" are equal"  );
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else    //Case parsing input validation is unsuccessful
                {
                    Console.WriteLine("Parsing unsuccessful. Invalid values entered");
                }

                Console.WriteLine("Wanna try again? Write your first number then!");    //Program loop around here
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
