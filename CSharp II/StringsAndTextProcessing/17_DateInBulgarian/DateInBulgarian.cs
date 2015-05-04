using System;
using System.Globalization;
using System.Text;

namespace _17_DateInBulgarian
{
    /*Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/
    class DateInBulgarian
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;  //Set console output to unicode

            while (true)
            {
                Console.Write("Please enter your date in the format d.M.yyyy h:m:s, sir\n-->");
                string dateValidator = Console.ReadLine(); //"5.5.2002 12:25:51";
                DateTime dateStart = new DateTime();

                if (DateTime.TryParseExact(dateValidator, "d.M.yyyy h:m:s", CultureInfo.GetCultureInfo("BG-bg"),
                    DateTimeStyles.None, out dateStart))
                {
                    //Validating input

                    string dayOfWeek = dateStart.DayOfWeek.ToString();
                    dateStart = dateStart.AddHours(6).AddMinutes(30);
                    string dayInBulgarian = dateStart.DayOfWeek.ToString();

                    Console.WriteLine(dateStart.ToString("dd.MM.yyyy HH:mm:ss dddd"),
                        CultureInfo.GetCultureInfo("BG-bg"));
                    //Printing date and day of week in bulgarian
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }

        }
    }
}
