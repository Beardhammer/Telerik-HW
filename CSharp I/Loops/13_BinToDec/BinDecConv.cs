using System;
using System.Linq;

namespace _13_BinToDec
{
    /*Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
binary 	decimal
0 	0
11 	3
1010101010101011 	43691
1110000110000101100101000000 	236476736
>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	binary
0 	0
3 	11
43691 	1010101010101011
236476736 	1110000110000101100101000000                                */
    class BinDecConv
    {
        static void Main()
        {
            while(true)
            { 

            Console.WriteLine("Which conversion program should I initialise?\nDec-->Bin or Bin-->Dec? b-d/d-b\nNote: Entering jump while in one program will halt its execution and ask you again what to initialise");
            string userAnswer = Console.ReadLine();
            int loopIsRunning = 0;
//>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
            if (userAnswer == "d-b")  //I'm overall not happy with how this particular one turned out. Any suggestions on how to improve will be very appreciated!
            {
                Console.WriteLine("Please enter your decimal number");
                while (loopIsRunning==0)
                { 
                    string decVal = Console.ReadLine();
                    long binTemp;   
                    long divisionLimiter;
                    string invertedBinary = "";
                    int e;
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (long.TryParse(decVal, out binTemp)) //Input validation
                    {
                        divisionLimiter = binTemp;
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        while (divisionLimiter>0) //Keeps dividing until our number's current value becomes<=0
                        {
                            if (divisionLimiter%2 == 0) //Adds a 0 or 1 depending on whether there is leftover from the division or not
                            {
                                invertedBinary += "0";
                            }
                            else if (divisionLimiter%2 != 0)
                            {
                                invertedBinary += "1";
                            }
                            divisionLimiter = divisionLimiter/2;    //Our number's current value is halved here
                        }
                    }
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else if (decVal == "Jump")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nParse unsuccessful. Is your input fully numeric?");
                    }
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    string normalBinary = "";
                    char[] array = invertedBinary.ToCharArray();    //So much code. So unneeded. I couldn't figure out a shorter way to invert "invertedBinary"

                    foreach (char number in array.Reverse())
                    {
                        normalBinary += number;
                    }

                    Console.WriteLine(normalBinary+"\nDo you want to try another one?");
                }
            }
//>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
            else if (userAnswer == "b-d")
            {
                Console.WriteLine("Please enter your binary number");

                while (loopIsRunning == 0)
                {

              //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    string binVal = Console.ReadLine();
                    long dec = 0;
                    long part1 = 0;
                    long part2 = 0;
                    int length = binVal.Length - 1;
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (!binVal.Except("01").Any()) //Input validation :p
                    {
                        for (int i = 0; i <= length; i++)
                        {
                            long.TryParse(binVal.Substring((length - i), 1), out part1);
                                //Takes substring at location i(whuch increases every loop) and later multiplies it by 2^i. That'a the formula I used
                            part2 = ((long) Math.Pow(2, i)); //Formula is broken into 2 parts to make it more readable

                            dec += part1*part2;
                        }
                        Console.WriteLine("The decimal representation of your number is: " + dec); //Prints result
                    }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else if (binVal == "Jump")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is no binary number!");
                    }
                    Console.WriteLine("Please enter your next binary number");
                }
            }
//>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
            }
        }
    }
}
