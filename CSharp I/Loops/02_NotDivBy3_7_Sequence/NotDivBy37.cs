using System;
using System.Globalization;
using System.Threading;

namespace _02_NotDivBy3_7_Sequence
{
    /*Problem 2. Numbers Not Divisible by 3 and 7

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

Examples:
n 	output
3 	1 2
10 	1 2 4 5 8 10            */
    class NotDivBy37
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please input length of the serie");
            Console.WriteLine("Please input first divisible");      //User is allowed to choose their own divisibles, rather than be limited to 3 and 7
            Console.WriteLine("Please input second divisible\n");
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                string inputValidator = Console.ReadLine();
                string firstDivValidator = Console.ReadLine();
                string secondDivValidator = Console.ReadLine();
                uint inputNum = 0;
               
                uint firstDivNum = 0;
                uint secondDivNum = 0;

                if (uint.TryParse(inputValidator, out inputNum) && uint.TryParse(firstDivValidator, out firstDivNum) && uint.TryParse(secondDivValidator, out secondDivNum))        //Checks input for non-numeric elements
                {
             //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    Console.Write("Your numbers are: ");
                    for (int i = 1; i <= inputNum; i++)    //i increases+1 every loop until it becomes <=user input
                    {
                        if (i%firstDivNum != 0 && i%secondDivNum != 0)   //Checks whether current number is divisble by 3 and 7
                        {
                            Console.Write(i + " "); //Prints number if not divisible
                        }
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
