using System;
using System.Globalization;
using System.Threading;

namespace _08_Num1ToN
{
    /*Problem 8. Numbers from 1 to n

    Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

Note: You may need to use a for-loop.

Examples:
input 	output
    3   1
	    2
	    3
    5 	1
	    2
	    3
	    4
	    5
    1 	1                       */
    class Num1ToN
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)                       //Special number used to keep the program running.....forever....spooky
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Please enter number of... numbers you'll be printing, mate");
                string numberValidator = Console.ReadLine();
                int number;                   //User defines length of the sequence through input

                if (int.TryParse(numberValidator, out number))  //Input is checked for non-numeric characters
                {
              //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    Console.WriteLine("Here you go: \n");
                    for (int i = 1; i <= number; i++) 
                    {
                        Console.WriteLine(i+", ");              //Sequence is printed
                    }
                    Console.WriteLine("\nWanna try another one?");
              //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("Your number is invalid. Try again?");    //Error message in case of failed parse
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
