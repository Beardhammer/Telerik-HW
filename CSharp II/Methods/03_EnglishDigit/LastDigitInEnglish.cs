using System;
using System.Speech.Synthesis;

namespace _03_EnglishDigit
{
    /*Problem 3. English digit

    Write a method that returns the last digit of given integer as an English word.

Examples:
input 	output
512 	two
1024 	four
12309 	nine                            */
    class LastDigitInEnglish
    {
        static void Main()  //Ctrl+k+c --> comment, Ctrl+k+u --> uncomment.  Choose whichever version you like
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            while (true)
            {
                Console.Write("Please enter your number\n-->");
                string userInputValidator = Console.ReadLine();
                Console.Write("Which method shall we use?\n1-->Numeric division method\n2-->Last string extraction method\n-->");
                string userAnwer = Console.ReadLine();
                if (userAnwer=="1")
                {
                    while (true)
                    {
                        int userInput;
                            //-->Second version. Not reliant on other stuff, but takes almost twice the time for calculations due to parsing. Without input validation, this method would be more than 10 times faster than the other one
                        if (int.TryParse(userInputValidator, out userInput))
                        {
                            Console.WriteLine("Your digit is --> " + LastDigitNumericVariant(userInput));
                            synth.Speak("Your digit is " + LastDigitNumericVariant(userInput));
                            break;
                        }
                        else    //Else is redundant, but helps with readibility
                        {
                            Console.WriteLine("Your input is invalid. Please try again");
                            userInputValidator = Console.ReadLine();
                        }
                    }
                }
                else if(userAnwer=="2")
                {
                    while (true)
                    {
                        if (userInputValidator.Length > 0)
                            //-->First version. Offers superior performance to other one, but is also reliant on stuff like substring extraction
                        {
                            Console.WriteLine("Your digit is --> " + LastDigitStringVariant(userInputValidator));
                            synth.Speak("Your digit is " + LastDigitStringVariant(userInputValidator));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Your input is invalid. Please try again");
                            userInputValidator = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please only choose either 1 or 2");
                }
            }
        }
        static string LastDigitNumericVariant(int userItem)
        {
            string lastDigit;
            switch (userItem%10)
            {
                case 0:
                    lastDigit = "zero";
                    break;
                case 1:
                    lastDigit = "one";
                    break;
                case 2:
                    lastDigit = "two";
                    break;
                case 3:
                    lastDigit = "three";
                    break;
                case 4:
                    lastDigit = "four";
                    break;
                case 5:
                    lastDigit = "five";
                    break;
                case 6:
                    lastDigit = "six";
                    break;
                case 7:
                    lastDigit = "seven";
                    break;
                case 8:
                    lastDigit = "eight";
                    break;
                case 9:
                    lastDigit = "nine";   //NEIN!!!
                    break;
                default:    //This will never happen, but I'll leave it in case of a magician user
                    lastDigit = "bullshit";
                    break;


            }
            return lastDigit;
        }
        static string LastDigitStringVariant(string userItem)
        {
            string lastDigit;
           switch (userItem.Substring(userItem.Length - 1))
            {
                case "0":
                    lastDigit = "zero";
                    break;
                case "1":
                    lastDigit = "one";
                    break;
                case "2":
                    lastDigit = "two";
                    break;
                case "3":
                    lastDigit = "three";
                    break;
                case "4":
                    lastDigit = "four";
                    break;
                case "5":
                    lastDigit = "five";
                    break;
                case "6":
                    lastDigit = "six";
                    break;
                case "7":
                    lastDigit = "seven";
                    break;
                case "8":
                    lastDigit = "eight";
                    break;
                case "9":
                    lastDigit = "nine";   //NEIN!!!
                    break;
               default:
                    lastDigit = "bullshit";
                    break;


            }
           return lastDigit;
        }
    }
}
