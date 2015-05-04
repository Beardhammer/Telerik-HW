using System;
using System.Globalization;
using System.Threading;

namespace _09_SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true) //Special "while" used to keep the program running.....forever....spooky
            {
                Console.WriteLine("User will now write n numbers, separated by spaces. ");
                string[] userInputArray = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);   //Second most difficult line of code I've ever had to write. Didn't even know these options existed!
                double sum = 0;                             //Always null you variables! Not with "null", though

                foreach (string number in userInputArray)   //Starts loop for each member of the array, which the user has input to
                {
              //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    double itemParsedValue = 0;
                    if (double.TryParse(number, out itemParsedValue))   //Tries to parse each element
                    {
                        sum += itemParsedValue;                         //Prints element on successful parse
                    }
                 //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else
                    {
                        Console.WriteLine("Element \"" + number + "\" could not be parsed");           //Error message in case an element is not successfully parsed
                    }
               //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                Console.WriteLine("Sum of all elements is : " + sum + "\nDo you wish to repeat?\n");   //Prints sum of all elements

            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
