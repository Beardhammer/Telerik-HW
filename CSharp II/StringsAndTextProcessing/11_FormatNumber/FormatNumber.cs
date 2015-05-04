using System;
using System.Globalization;
using System.Threading;

namespace _11_FormatNumber
{
    /*Problem 11. Format number

    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    Format the output aligned right in 15 symbols.
                                                                    */
    class FormatNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture=CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Please enter your number and I'll format it to whatever I'm told, baby!\n-->");
                string userInputValidator = Console.ReadLine();
                int x = 0;
                if (int.TryParse(userInputValidator, out x))
                {
                    Console.WriteLine("Decimal: " + x.ToString("###.0##") +
                                      ",\nHexadecimal: " + x.ToString("X") +
                                      ",\nPercentage: " + x.ToString("P") +
                                      ",\nScientific notation: " + x.ToString("E"));
                }
                else
                {
                    Console.WriteLine("Your number is not a valid integer. Please try again");
                }
            }
        }
    }
}
