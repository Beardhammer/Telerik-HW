using System;
using System.Globalization;
using System.Threading;

namespace _01_Date
{
    /*Problem 1. Leap year

    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
                                                    */
    class LeapYearCalculator
    {
        static void Main()
        {
            while (true)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Console.Write("Please enter your year\n-->");
                string userDateValidator = Console.ReadLine();

                IsItALeapYear(userDateValidator);
                IsYearLeapYear(userDateValidator);
                Console.WriteLine();
            }

        }

        private static void IsItALeapYear(string userDate)  //No need to return bool
        {
            DateTime userDateTime = new DateTime(1, 1, 1);
            int userYear = 0;

            if ((int.TryParse(userDate, out userYear) && userYear > 0 && userYear<=9999) || 
                (DateTime.TryParse(userDate, out userDateTime)))
            {
                if (userYear > 0) userDateTime = new DateTime(userYear, 1, 1);

                if ((userDateTime.Year % 4 == 0 && userDateTime.Year % 100 != 0) || 
                    (userDateTime.Year % 4 == 0 && userDateTime.Year % 400 == 0))
                {
                    Console.WriteLine("Method 1 --> Yes, it is a leap year");
                    return;
                }
            }
            Console.WriteLine("Method 1 --> No, it is not a leap year");
            //If year%4=0 and it is either divisible by 400 or not divisible by 100, then it is a leap year
        }

        private static void IsYearLeapYear(string userDate)
        {
            DateTime userDateTime = new DateTime(1, 1, 1);
            int userYear = 0;

            if (DateTime.TryParse(userDate, out userDateTime)) userYear = userDateTime.Year;

            Console.WriteLine(
                (((int.TryParse(userDate, out userYear) && userYear > 0 && userYear <= 9999) ||
                (userYear > 0 && userYear <= 9999))
                && (DateTime.IsLeapYear(userYear))
                    ? "Method 2 --> Yes, it is a leap year"
                    : "Method 2 --> No, it is not a leap year"));
            //If user has entered valid year or valid date(which modifies the year, therefore skipping the parse check) then year is checked for....leaping, I guess?
        }
    }
}
