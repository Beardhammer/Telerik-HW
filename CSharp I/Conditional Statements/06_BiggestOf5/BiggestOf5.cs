using System;
using System.Globalization;
using System.Threading;

namespace _06_BiggestOf5
{
    /*Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.// 2 ifs! hahaha!

Examples:
a 	b 	c 	d 	e 	biggest
5 	2 	2 	4 	1 	5
-2 	-22 	1 	0 	0 	1
-2 	4 	3 	2 	0 	4
0 	-2.5 	0 	5 	5 	5
-3 	-0.5 	-1.1 	-2 	-0.1 	-0.1                        */
    class BiggestOf5
    {
        static void Main()  //Actually, it's biggest of n, cause it can accept as many numbers as you can fit on one line. They're doubles, though, so don't go crazy!
        {
            Console.WriteLine("Thou shalt now inputeth thine numbers");
            while (true)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                string[] userInputArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);  //User input is saved in this array

                double currentNumber = 0;
                double lastNumber = 0;
                double largestNumber = double.MinValue;
                
                foreach (string numberForComparison in userInputArray)       //Looking through the array(user input)
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (double.TryParse(numberForComparison, out currentNumber))         //Looking for numbers
                    {
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        double temp = lastNumber;    //temporarily takes the value of lastNumber, which has taken the last(not current) value of currentNumber
                        lastNumber = currentNumber;  //lastNumber takes the value of currentNumber, which will be used in next loop
                        double largestOfCurrentAndLast = Math.Max(largestNumber, currentNumber);    //Gets the larger between currentNumber and lastNumber           ||
                        if (largestOfCurrentAndLast > largestNumber)        //If gotten value of largestOfCurrentAndLast is larger than largestNumber current value, \/ 
                        {                                                   //then largestNumber gets current value of largestOfCurrentAndLast                     <===
                            largestNumber = largestOfCurrentAndLast; 
                        }
                  //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                    else
                    {
                        Console.WriteLine("\nElement \"" + numberForComparison + "\" is not a valid number!");    //Prints out any invalid values
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                Console.WriteLine("\nThine biggest number is: " + largestNumber);      //Prints biggest number
                Console.WriteLine("\nDoth thee want to try with more numbers? Enter thine first one then!");    //Program lops around here
            }
        }
    }
}