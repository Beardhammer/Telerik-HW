using System;

namespace _14_ModBitAtPosition
{
    /*Problem 14. Modify a Bit at Given Position

    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

Examples:
n 	binary representation of n 	p 	v 	binary result 	result
5 	00000000 00000101 	2 	0 	00000000 00000001 	1
0 	00000000 00000000 	9 	1 	00000010 00000000 	512
15 	00000000 00001111 	1 	1 	00000000 00001111 	15
5343 	00010100 11011111 	7 	0 	00010100 01011111 	5215
62241 	11110011 00100001 	11 	0 	11110011 00100001 	62241       */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number ,.... Master?");
            for (var e = 1; e <= 50000; e++)    //Keeps program looping
            {
                String inputValidator = Console.ReadLine();    //Used in input validation
                int userNumberForCheck;                        //Gets input data if valid later
                Console.WriteLine("Index from right to left");
                String inputValidatorIndex = Console.ReadLine();    //Used in input validation
                int userIndexForCheck;                        //Gets input data if valid later
                Console.WriteLine("Please insert new value");
                String inputValidator01 = Console.ReadLine();    //Used in input validation
                int user01ForCheck;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (int.TryParse(inputValidator, out userNumberForCheck) & int.TryParse(inputValidatorIndex, out userIndexForCheck) & int.TryParse(inputValidator01, out user01ForCheck))   //checks if input is numeric
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    string inBinary = Convert.ToString(userNumberForCheck, 2);  //Gets input and converts to binary
                    if (userIndexForCheck < inBinary.Length)   //Checks input length in binary
                    {
                        var checkPositionValue = inBinary.Substring((inBinary.Length-(userIndexForCheck+1)), 1);
                        inBinary = inBinary.Remove(inBinary.Length-(userIndexForCheck+1), 1).Insert(inBinary.Length-(userIndexForCheck+1), inputValidator01);
                        int inDec = Convert.ToInt32(inBinary, 2);
                        Console.WriteLine("Your number in binary: " + inBinary + "\nYour index: " + userIndexForCheck + "\nCurrent value: " + checkPositionValue + "\nNew value: " + user01ForCheck + "\nDec: " + inDec);

                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid");
                    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("Your input is invalid"); //Error message in case of invalid input
                }
                Console.WriteLine("Wanna try another one?");
            }
        }
    }
}
