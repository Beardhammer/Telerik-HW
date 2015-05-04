using System;
using System.Linq;

namespace _15_16_HexDecConv
{
    /*Problem 15. Hexadecimal to Decimal Number

    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
hexadecimal 	decimal
FE 	254
1AE3 	6883
4ED528CBB4 	338583669684
>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
Problem 16. Decimal to Hexadecimal Number

    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	hexadecimal
254 	FE
6883 	1AE3
338583669684 	4ED528CBB4                      */

    internal class HexToDecConv
    {
        private static void Main()
        {
            while (true)
            {
//>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
                Console.WriteLine(
                    "Which conversion program should I initialise?\nHex-->Dec or Dec-->Hex? h-d/d-h\nNote: Entering jump while in one program will halt its execution and ask you again what to initialise");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "h-d")
                {
                    Console.Write("Enter your decimal number: ");
                    while (true)
                    {
//>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
                        string inputValidator = Console.ReadLine();
                        long userDecNum;
                        if (long.TryParse(inputValidator, out userDecNum))
                        {
                            long leftover;
                            string hexadecimal = "";
                            if (userDecNum == 0)
                            {
                                Console.WriteLine("Hexadecimal number: 0");
                            }
                            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            else
                            {
                                while (userDecNum > 0)
                                {
                                    leftover = userDecNum%16;
                                    switch (leftover)
                                    {
                                        case 10:
                                            hexadecimal += 'A';
                                            break;
                                        case 11:
                                            hexadecimal += 'B';
                                            break;
                                        case 12:
                                            hexadecimal += 'C';
                                            break;
                                        case 13:
                                            hexadecimal += 'D';
                                            break;
                                        case 14:
                                            hexadecimal += 'E';
                                            break;
                                        case 15:
                                            hexadecimal += 'F';
                                            break;
                                        default:
                                            hexadecimal += leftover.ToString();
                                            break;
                                    }
                                    userDecNum /= 16;
                                }
                                Console.Write("Hexadecimal number: ");
                                for (int position = hexadecimal.Length - 1; position >= 0; position--)
                                {
                                    Console.Write(hexadecimal[position]);
                                }
                                Console.WriteLine();
                            }
                        }
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        else if (inputValidator == "Jump")  //Jumps to other program
                        {
                            break;
                        }
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        else
                        {
                            Console.WriteLine("\nThat is no number!\n");
                        }
                        Console.WriteLine("Wanna enter another one?");
                    }
                }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else if (userAnswer == "d-h")
                {
                    while (true)
                    {
//>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
                        Console.WriteLine("Please enter your hexadecimal number");
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        string binVal = Console.ReadLine();
                        long dec = 0;
                        long part1 = 0;
                        long part2 = 0;
                        int length = binVal.Length - 1;
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (!binVal.Except("0123456789abcdefABCDEF").Any()) //Input validation :p
                        {
                            for (int i = 0; i <= length; i++)
                            {
                                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                if (long.TryParse(binVal.Substring((length - i), 1), out part1))
                                {
                                    part2 = ((long) Math.Pow(16, i));   //Formula for hex-->Dec
                                    dec += part1*part2;
                                }
                                else if (binVal == "Jump")
                                {
                                    break;
                                }
                                else
                                {
                                    switch (binVal.Substring((length - i), 1))
                                    {
                                        case "A":
                                            part1 = 10;
                                            break;
                                        case "a":
                                            part1 = 10;
                                            break;
                                        case "B":
                                            part1 = 11;
                                            break;
                                        case "b":
                                            part1 = 11;
                                            break;
                                        case "C":
                                            part1 = 12;
                                            break;
                                        case "c":
                                            part1 = 12;
                                            break;
                                        case "D":
                                            part1 = 13;
                                            break;
                                        case "d":
                                            part1 = 13;
                                            break;
                                        case "E":
                                            part1 = 14;
                                            break;
                                        case "e":
                                            part1 = 14;
                                            break;
                                        case "F":
                                            part1 = 15;
                                            break;
                                        case "f":
                                            part1 = 15;
                                            break;
                                    }
                                    part2 = ((long) Math.Pow(16, i));
                                    dec += part1*part2;
                                }
                                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            }
                            Console.WriteLine("The decimal representation of your number is: " + dec); //Prints result
                        }
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        else if (binVal == "Jump")  //Jumps to other program
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That is no decimal number!");    //In case input is not recognised as a hex number
                        }
                        Console.WriteLine("Please enter your next hexadecimal number");
                    }
//>>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>----------------------------->>>>
                }
                else
                {
                    Console.WriteLine("Please enter a valid mode!");
                }
            }
        }
    }
}