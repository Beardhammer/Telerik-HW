using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace _05_Workdays
{
    /*Problem 5. Workdays

    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
                                                                                                                                            */
    class WorkdayCalculator
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                Console.WriteLine("Please enter a valid date for calculations");    //Sorry about this line being difficult to understand. I just couldn't figure out what do write here
                string targetDateValidator = Console.ReadLine();
                DateTime targetDate = new DateTime();


                if (DateTime.TryParse(targetDateValidator, out targetDate))     //This is rough input validation
                {
                    WorkDay(targetDate);
                }
                else
                {
                    Console.WriteLine("Invalid date. Please check your input and try again");
                }
            }
        }

        static void WorkDay(DateTime targetDate)
        {
            DateTime today = DateTime.Today.AddDays(1);
            List<DateTime> holidaysArray = new List<DateTime>   //List used instead of array due to large performance gain
            {
                new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
                new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
                new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
                new DateTime(2015, 12, 24), new DateTime(2015, 12, 25), new DateTime(2015, 12, 30),
            };

            int workingDays = 0;
            int holidays = 0;

            while (today <= targetDate)     //Today is not included in the calculations
            {
                if ((holidaysArray.Contains(today)) || today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)    //Weekends and holidays are treated identically
                {
                    holidays++;
                }
                else
                {
                    workingDays++;
                }
                today = today.AddDays(1);
            }

            Console.WriteLine("Workdays: " + workingDays + "\nHolidays count: " + holidays + "\nTotal number of days: " + (holidays + workingDays));
        }
    }
}
