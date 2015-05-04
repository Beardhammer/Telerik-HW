using System;

namespace _03_DayOfTheWeek
{
    /*
     Problem 3. Day of week

    Write a program that prints to the console which day of the week is today.
    Use System.DateTime.
                                */
    class DayOfTheWeek
    {
        static void Main()
        {
            Console.WriteLine("Today is "+DateTime.Now.DayOfWeek);  //Directly gets and prints day of week
        }
    }
}
