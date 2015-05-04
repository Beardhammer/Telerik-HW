using System;

namespace _15_BitExch
{
    /*Problem 15.* Bits Exchange

    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

Examples:
n 	binary representation of n 	binary result 	result
1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
5351 	00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705              */
    class Program
    {
        static void Main(string[] args) //EXTREMELY crude method used. Brain too tired to work. Understanding c# not good either. Would love to receive links to other methods
        {
            Console.WriteLine("What is your number ,.... Master?");
            for (var e = 1; e <= 50000; e++) //Keeps program looping
            {
                string inputValidator = Console.ReadLine();
                uint userInputNumber;
                if (uint.TryParse(inputValidator, out userInputNumber))
                {
                    
                    string inBinary = Convert.ToString(userInputNumber, 2);  //Gets input and converts to binary
                    int inBinLength = inBinary.Length-1;
                    Console.WriteLine(inBinary.PadLeft(32, '0'));
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    var exch3 = inBinary.Substring(inBinLength - 3, 1);     //Saving values we'll be swapping later
                    var exch4 = inBinary.Substring(inBinLength - 4, 1);
                    var exch5 = inBinary.Substring(inBinLength - 5, 1);
                    var exch24 = inBinary.Substring(inBinLength - 24, 1);
                    var exch25 = inBinary.Substring(inBinLength - 25, 1);
                    var exch26 = inBinary.Substring(inBinLength - 26, 1);
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    inBinary = inBinary.Remove(inBinLength - 3, 1).Insert(inBinLength - 3, exch24);     //Swapping values
                    inBinary = inBinary.Remove(inBinLength - 4, 1).Insert(inBinLength - 4, exch25);
                    inBinary = inBinary.Remove(inBinLength - 5, 1).Insert(inBinLength - 5, exch26);
                    inBinary = inBinary.Remove(inBinLength - 24, 1).Insert(inBinLength - 24, exch3);
                    inBinary = inBinary.Remove(inBinLength - 25, 1).Insert(inBinLength - 25, exch4);
                    inBinary = inBinary.Remove(inBinLength - 26, 1).Insert(inBinLength - 26, exch5);
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    int inDec = Convert.ToInt32(inBinary, 2);
                    Console.WriteLine(inBinary.PadLeft(32, '0'));
                    Console.WriteLine(inDec);

                }
                else
                {
                    Console.Write("Invalid input. Please try again");
                }
            }
        }
    }
}
