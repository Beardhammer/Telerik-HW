using System;
using System.Globalization;
using System.Threading;

namespace _05_SumOf5Numbers
{
    /*Problem 7. Sum of 5 Numbers

    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

Examples:
numbers 	sum
1 2 3 4 5 	15
10 10 10 10 10 	50
1.5 3.14 8.2 -1 0 	11.84           */
    class SumOf5Num
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true) //Special "while" used to keep the program running.....forever....spooky
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("User will now enter length of sequence(Default: 5)");
                string lengthSequenceValidator = Console.ReadLine();
                int lengthSequence = 0;                                         //Always null your variables! Not with "null", though
                
                if (int.TryParse(lengthSequenceValidator, out lengthSequence))  //Length input is checked for invalid characters
                {
             //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    Console.WriteLine("User will now enter N numbers and separate them wth a space");
                    string[] userInputArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);   //All user input is saved in an array

                    double sum = 0; 
                    Array.Resize(ref userInputArray, lengthSequence);   //Array is resized to fit user input

                    foreach (string number in userInputArray)           //Loop checks every element for numerics
                    {
                     //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        double x = 0;
                        if (double.TryParse(number, out x))             //If element is parsed, it is added to var sum
                        {
                            sum += x;
                        }
                     //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                    Console.WriteLine("Sum of first 5 elements is : " + sum + "\nDo you wish to repeat?\n");    //Result is printed
                }
             //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Input for Length of sequence is not a valid number! Try again.");        //In case user input for length isn't successfully parsed
                }

            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
