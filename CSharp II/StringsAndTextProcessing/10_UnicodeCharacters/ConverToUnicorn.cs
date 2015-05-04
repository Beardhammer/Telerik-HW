using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_UnicodeCharacters
{
    /*Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.

Example:
input 	output
Hi! 	\u0048\u0069\u0021                                      */
    class ConverToUnicorn
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your string for conversion\n-->");
                string userInput = Console.ReadLine();

                List<byte> conversionArray = Encoding.Unicode.GetBytes(userInput).ToList();   //Gets bytes of input string

                Console.Write("Your result: ");
                foreach (var item in conversionArray)
                {
                    if (item != 0) Console.Write("\\u" + item.ToString("X4") + " ");    //And then prints them in hexadecimal
                }
                Console.WriteLine();
            }
        }
    }
}
