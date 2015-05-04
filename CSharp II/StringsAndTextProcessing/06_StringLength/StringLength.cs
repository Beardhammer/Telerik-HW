using System;
using System.Text;

namespace _06_StringLength
{
    /*Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
                                                            */
    class StringLength
    {
        static void Main()  //Could use padleft/padright for this, but why not implement it myself while I'm at it?
        {
            while (true)
            {
                Console.Write("Please enter your string that need padding\n-->");
                string userInput = Console.ReadLine();  //User input

                StringBuilder userInputBuilder = new StringBuilder();
                userInputBuilder.Append(userInput);     

                if (userInput.Length > 20 || string.IsNullOrWhiteSpace(userInput))  //Throws and exception on empty string or string > 20 chars
                {
                    throw new Exception("Your string is bigger than 20 characters or null");    //Is this how you throw an exception? Anything more I need to know?
                }
                else
                {
                    for (int i = 0; i < 20 - userInput.Length; i++) //Pad string with "*" until its length is 20
                    {
                        userInputBuilder.Append("*");
                    }
                }
                Console.WriteLine("Your string --> " + userInputBuilder);
            }
        }
    }
}
