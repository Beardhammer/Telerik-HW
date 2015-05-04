using System;
using System.Globalization;
using System.Threading;

namespace _04_NumCompare
{
    /*Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.

Examples:
a 	b 	greater
5 	6 	6
10 	5 	10
0 	0 	0
-5 	-2 	-2
1.5 	1.6 	1.6         */
    class NumCompareNoIf
    {
        static void Main()//Make it compare hex and binary?
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            while (true)                    //Special "while" used to keep program running.....forever....spooky
            {
                Console.WriteLine("Please enter dein first number");
                string num1Validator = Console.ReadLine();          //User first number
                Console.WriteLine("Please enter dein zecond number");
                string num2Validator = Console.ReadLine();          //User second number

                double num1;    
                double num2;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (double.TryParse(num1Validator, out num1) && double.TryParse(num2Validator, out num2))   //Input is checked for non-numeric elements
                {
                    Console.WriteLine("The largest number is: " + Math.Max(num1, num2));    //Math function used instead of "if" statements
                }
                else
                {
                    Console.Write("\nDein numbers are INVALID!!!!!!\n");
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
