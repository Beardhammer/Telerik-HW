using System;

namespace _13_ChkBit
{
    /*Problem 13. Check a Bit at Given Position

        Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

    Examples:
    n 	binary representation of n 	p 	bit @ p == 1
    5 	00000000 00000101 	2 	true
    0 	00000000 00000000 	9 	false
    15 	00000000 00001111 	1 	true
    5343 	00010100 11011111 	7 	true
    62241 	11110011 00100001 	11 	false           */
    class Program
    {
        static void Main(string[] args) //Please note that counting always begins with 0!
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
                    if (userIndexForCheck < inBinary.Length)   //Checks input length in binary
                    {
                        var checkPositionValue = inBinary.Substring((inBinary.Length-userIndexForCheck), 1);    //Gets substring at defined position
                        bool x = checkPositionValue=="1";   //True if checkPositionValue==1
                        Console.WriteLine("The binary representation of your number is: {0}\nThe digit in position {1}(R->L) is 1 - {2}", inBinary, userIndexForCheck, x);
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
