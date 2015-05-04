using System;

namespace _12_ExtractBitFromInt
{
    /*Problem 12. Extract Bit from Integer

    Write an expression that extracts from given integer n the value of given bit at index p.

Examples:
n 	binary representation 	p 	bit @ p
5 	00000000 00000101 	2 	1
0 	00000000 00000000 	9 	0
15 	00000000 00001111 	1 	1
5343 	00010100 11011111 	7 	1
62241 	11110011 00100001 	11 	0           */
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

                if (int.TryParse(inputValidator, out userNumberForCheck) & int.TryParse(inputValidatorIndex, out userIndexForCheck))   //checks if input is numeric
                {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    string inBinary = Convert.ToString(userNumberForCheck, 2);  //Gets input and converts to binary
                    if (userIndexForCheck<inBinary.Length)   //Checks input length in binary
                    {
                        var checkPositionValue = inBinary.Substring((inBinary.Length-(userIndexForCheck+1)), 1);
                        Console.WriteLine("The binary representation of your number is: {0}\nThe digit in position {1}(R->L) is {2}", inBinary,userIndexForCheck ,checkPositionValue);
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
