using System;

namespace _06_ModNumber
{
    /*      Problem 6. Four-Digit Number

    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).

The number has always exactly 4 digits and cannot start with 0.

Examples:
n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
2011 	4 	1102 	1201 	2101
3333 	12 	3333 	3333 	3333
9876 	30 	6789 	6987 	9786            
                                                            */
    class Program   //Make it rearrange strings as well
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many characters will be the max allowed?(4 is a common number)");
            int maxCharCount;                                 //Based on user input. Max number of chars allowed in string
            string lengthValidator = Console.ReadLine();      //Reads user input
            if (int.TryParse(lengthValidator, out maxCharCount))    //Checks if user input is numeric
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                for (int e = 1; e <= 50000; e++)
                {
                    Console.WriteLine("Write your number");
                    string userInput = Console.ReadLine();          //User inputs something
                    int userInputLength = userInput.Length - 1;       //Gets length of user input -1


                    if (userInput.Length <= maxCharCount)
                    {
                        int userInputValidator;
                        int sumOfAllNumbers = 0;                        //Sum of all digits will be put here later
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (int.TryParse(userInput, out userInputValidator))      //Trying to make sure all input is numerical so program doesn't crash during calculations. TryParse could also be use here, but for the sake of simplifying the code, !Except is better
                        {
                            Console.Write("Your numbers in reverse: ");
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            for (int i = 0; i <= userInputLength; i++)  //Used in rearranging backwards
                            {
                                string userInputReverser = userInput.Substring((userInputLength - i), 1);   //Gets highest substring index values first

                                sumOfAllNumbers = sumOfAllNumbers + Convert.ToInt32(userInputReverser);     //Used to get sum of digits
                                Console.Write(userInputReverser);                                           //Writes everything backwards
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            Console.WriteLine("\nSum is: " + sumOfAllNumbers);

                            string secondDigit = userInput.Substring(2, 1);                 //Gets item at 2st index(3nd place)
                            string firstDigit = userInput.Substring(1, 1);                  //Gets item at 1st index(2nd place)
                            string lastDigit = userInput.Substring(userInputLength, 1);     //Gets item at last index

                            string lastDigitInFront = userInput.Remove(userInputLength, 1).Insert(0, lastDigit);    //New string used last digit in front visualisation

                            userInput = userInput.Remove(1, 1).Insert(1, secondDigit);      //Replaces item at 1st index with secondDigit
                            userInput = userInput.Remove(2, 1).Insert(2, firstDigit);       //Replaces item at 2nd index with firstDigit. Basically, it swaps characters at indexes 1 and 2 

                            Console.WriteLine("Last digit in front: " + lastDigitInFront);  //Prints result of swap of first and last digit
                            Console.WriteLine("Second and third digits exchanged: " + userInput);   //Prints result of swap

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        }
                        else if (!string.IsNullOrWhiteSpace(userInput))
                        {
                            char[] inversionArray = userInput.ToCharArray();        //Turns userinput in an array, so I don't have to use a loop again
                            Array.Reverse(inversionArray);                          //Inverts array
                            string userInputReversed = new string(inversionArray);  //Puts inverted array into string
                            Console.WriteLine("Your characters in reverse: " + userInputReversed);  //Prints inverted array
                            

                            string secondDigit = userInput.Substring(2, 1);                 //Gets item at 2st index(3nd place)
                            string firstDigit = userInput.Substring(1, 1);                  //Gets item at 1st index(2nd place)
                            string lastDigit = userInput.Substring(userInputLength, 1);     //Gets item at last index

                            string lastDigitInFront = userInput.Remove(userInputLength, 1).Insert(0, lastDigit);    //New string used last digit in front visualisation

                            userInput = userInput.Remove(1, 1).Insert(1, secondDigit);      //Replaces item at 1st index with secondDigit
                            userInput = userInput.Remove(2, 1).Insert(2, firstDigit);       //Replaces item at 2nd index with firstDigit. Basically, it swaps characters at indexes 1 and 2 

                            Console.WriteLine("Last digit in front: " + lastDigitInFront);  //Prints result of swap of first and last digit
                            Console.WriteLine("Second and third digits exchanged: " + userInput);   //Prints result of swap  
                        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        else
                        {
                            Console.WriteLine("Thine first digit mustn't be zero or null!");    //In case number input is non-numeric

                        }
                    }
                    else
                    {
                        Console.WriteLine("Too many characters");   //I case user exceeds number of allowed characters. Defined by usert beforehand
                    }
                }

            }
            else
            {
                Console.WriteLine("invalid input");     //In case lengthValidator Can't be parsed
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
