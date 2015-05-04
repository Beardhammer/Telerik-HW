using System;

namespace _12_RndOrder
{
    /*
     Problem 16. Decimal to Hexadecimal Number

    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	hexadecimal
254 	FE
6883 	1AE3
338583669684 	4ED528CBB4          */
    class RndOrder
    {
        private static void Main()
        {
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.Write("Please enter n: ");

                string numberVal = Console.ReadLine();  //User input
                int userN;

                if (int.TryParse(numberVal, out userN)) //Input mvlidation
                {
                    
                bool[] printed = new bool[userN + 1];
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Random randomNumbers = new Random();
                for (int i = 0; i < userN; i++) //Randomization happens here
                {
                    int rndTemp = randomNumbers.Next(1, userN + 1);
                    if (!printed[rndTemp])
                    {
                        Console.Write(rndTemp + " ");
                        printed[rndTemp] = true;
                    }
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    else
                    {
                        i--;
                    }
                }
                Console.WriteLine();
                }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("That's not a number, you!");
                }
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
    }
}
