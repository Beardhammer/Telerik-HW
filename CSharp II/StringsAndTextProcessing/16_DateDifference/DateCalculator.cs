using System;
using System.Globalization;

namespace _16_DateDifference
{
    /*Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
                                            */
    class DateCalculator
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your start date in the format dd/MM/yyyy\n-->");
                DateTime currentDateTime = new DateTime();  //User inputs their dates
                string userDate = Console.ReadLine();

                Console.Write("Please enter your next date in the same format\n-->");
                DateTime nextDateTime = new DateTime();
                string nextDate = Console.ReadLine();

                int days = 0;

                if ((DateTime.TryParseExact(userDate, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,out currentDateTime)) &&
                    (DateTime.TryParseExact(nextDate, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,out nextDateTime)))    //Dates are parse-checked
                {
                    while (currentDateTime < nextDateTime) 
                    {
                        days++;     //Increasing Days intill both dates are equal
                        currentDateTime = currentDateTime.AddDays(1);
                    }
                    Console.WriteLine("Difference is: " + days + " days\n");    //Printing result
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again\n"); //In case parse-check is unsuccessful
                }

            }
        }
    }
}
