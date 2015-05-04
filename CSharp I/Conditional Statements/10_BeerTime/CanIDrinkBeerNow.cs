using System;
using System.Globalization;
using System.Threading;

namespace _10_BeerTime
{
    /*Problem 10.* Beer Time

    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

Examples:
time 	result
1:00 PM 	beer time
4:30 PM 	beer time
10:57 PM 	beer time
8:30 AM 	non-beer time
02:59 AM 	beer time
03:00 AM 	non-beer time
03:26 AM 	non-beer time                       */
    class CanIDrinkBeerNow
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)    //Program loops forever
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Is it beer time yet?\nNote: format doesn't matter. Everything is accepted");
                string userDateTimeValidator = Console.ReadLine();  //Input is intially read as string
                DateTime beerOrNoBeer;
                if (DateTime.TryParse(userDateTimeValidator, out beerOrNoBeer)) //Attempted parse of input to DateTime format
                {
               //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        int currentTime = beerOrNoBeer.Hour;    //Gets current hour
                        int start = 13;     //Beer time definitions
                        int end = 3;
                        if ((currentTime >= start) || (currentTime < end))  //Checks whether it's beer time or not
                        {
                            Console.WriteLine("Yup, it's time!");
                        }
                        else
                        {
                            Console.WriteLine("Nope.");
                        }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("That's no time!");   //Error message in case of unsuccessful parse to DateTime
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
