using System;

namespace _11_Extract3rdBit
{
    /*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.

Examples:
n 	binary representation 	bit #3
5 	00000000 00000101 	0
0 	00000000 00000000 	0
15 	00000000 00001111 	1
5343 	00010100 11011111 	1
62241 	11110011 00100001 	0                   */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number ,.... Master?");
            for (var e = 1; e <= 50000; e++)    //Keeps program looping
            {
                String inputValidator = Console.ReadLine();    //Used in input validation
                int userNumberForCheck;                        //Gets input data if valid later

                if (int.TryParse(inputValidator, out userNumberForCheck))   //checks if input is numeric
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    string inBinary = Convert.ToString(userNumberForCheck, 2);  //Gets input and converts to binary
                    if (inBinary.Length >= 4)   //Checks input length in binary
                    {
                        var checkPositionValue = inBinary.Substring(inBinary.Length - 4, 1);
                        Console.WriteLine("The binary representation of your number is: {0}\nThe digit in 3rd place(from 0, R-L) is {1}", inBinary, checkPositionValue);
                    }
                    else
                    {
                        Console.WriteLine("Input too short. Closest number will be taken instead\n");
                        var checkPositionValue = inBinary.Substring(inBinary.Length - 1, 1);
                        Console.WriteLine("The binary presentation of your number is: {0}\nThe digit in first place(from 0, R-L) is {1}", inBinary, checkPositionValue);
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
