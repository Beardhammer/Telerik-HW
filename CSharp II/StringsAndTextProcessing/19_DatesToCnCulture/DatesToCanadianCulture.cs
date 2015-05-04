using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace _19_DatesToCnCulture
{
    /*Problem 19. Dates from text in Canada

    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.
                                                                    */
    class DatesToCanadianCulture
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA"); //Set culture to Canadian

            Console.WriteLine("Please enter your text with dates in the format: dd.MM.yyyy and I'll convert them all to some random Canadian format");
            string textValidator = Console.ReadLine();//"Hello, I am sample text, my date is 02.03.2002 , though that date has no meaning as I was written on 10.03.2015";

            List<string> converterList = textValidator.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            DateTime dateTimeValidator = new DateTime();    //Used in date validation

            for (int i = 0; i < converterList.Count; i++)
            {
                if (DateTime.TryParseExact(converterList[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValidator))
                {//If date that matches the format given is founde, then it is replaced with its Canadian formatted equilvalent
                    converterList[i] = dateTimeValidator.ToShortDateString().ToString(new CultureInfo("en-CA"));    //Just in case, I added more culture formatting! haha!
                }
            }
            Console.WriteLine("Your text with dates in Canadian format: " + string.Join(" ", converterList));
        }
    }
}
