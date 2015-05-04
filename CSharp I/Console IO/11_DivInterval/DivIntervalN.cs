using System;
using System.Globalization;
using System.Threading;

namespace _11_DivInterval
{
    /*Problem 11.* Numbers in Interval Dividable by Given Number

    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

Examples:
start 	end 	p 	comments
17 	25 	2 	20, 25
5 	30 	6 	5, 10, 15, 20, 25, 30
3 	33 	6 	5, 10, 15, 20, 25, 30
3 	4 	0 	-
99 	120 	5 	100, 105, 110, 115, 120
107 	196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195        */
    class DivIntervalN
    {
        static void Main()                                  //Says to use unsigned integers here. Don't blame me for lack of features! Personally, I would've used double types instead
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)                                    //Special "while" used to keep the program running.....forever....spooky
            {
                Console.WriteLine("Please enter first number of sequence");
                string userSequenceStartValidator = Console.ReadLine();
                UInt32 userNumberStart = 0;                 //Start of sequence. I nulled this because my common sense was tingling

                Console.WriteLine("Please enter last number of sequence of sequence");
                string userSequenceEndValidator2 = Console.ReadLine();
                UInt32 userNumberEnd = 0;                   //End of sequence. I nulled it for the same reason

                Console.WriteLine("Please enter the iterval at which numbers will be shown");
                string userDefinedIntervalValidator = Console.ReadLine();
                UInt32 userDefinedInterval = 5;             //Interval at which numbers are printed. 5 is default, though empty input won't be parsed anyway...
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (UInt32.TryParse(userSequenceStartValidator, out userNumberStart) && UInt32.TryParse(userSequenceEndValidator2, out userNumberEnd) && UInt32.TryParse(userDefinedIntervalValidator, out userDefinedInterval))
                {
                    for (uint i = userNumberStart; i <=userNumberEnd; i++)  //Crude method used here. I don't like it, but I don't have the time to search for and debug better methods right now. Plus at this point in our training, old and crude methods work good enough
                    {
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (i % userDefinedInterval == 0)   //Divides by user defined interval(uint). Prints if there are no decimal left overs
                        {
                            Console.WriteLine(i);
                        }
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                }
              //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Error in parsing. Are your numbers positve? Are they even numbers?");
                }
                Console.WriteLine("\nWant to try again?\n");
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
            }
        }
    }
}
