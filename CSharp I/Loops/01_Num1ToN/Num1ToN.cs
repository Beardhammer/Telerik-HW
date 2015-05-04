using System;
using System.Globalization;
using System.Threading;

namespace _01_Num1ToN
{
    /*Problem 1. Numbers from 1 to N

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

Examples:
n 	output
3 	1 2 3
5 	1 2 3 4 5                                   */
    class Num1ToN
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please input length of the serie ");
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                string inputValidator = Console.ReadLine();
                uint inputNum=0;

                if (uint.TryParse(inputValidator, out inputNum))        //Checks input for non-numeric elements
                {
             //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    for (int i = 1; i <= inputNum; i++)    //i increases+1 every loop until it becomes <=user input
                    {
                        Console.Write(i + " ");     //Prints i
                    }
             //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("\nParsing unsuccessful. Please check your input and try again"); //Case parse of user input is unsuccessful
                }
                Console.WriteLine("\nWanna try again?");    //Program loops around here
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
