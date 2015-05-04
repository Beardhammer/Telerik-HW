using System;

namespace _11_RndRange
{
    /*Problem 11. Random Numbers in Given Range

    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

Examples:
n 	min 	max 	random numbers
5 	0 	1 	1 0 0 1 1
10 	10 	15 	12 14 12 15 10 12 14 13 13 11

Note: The above output is just an example. Due to randomness, your program most probably will produce different results.                        */
    class RndInRange
    {
        static void Main()
        {
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Please enter how many numbers will be generated");   //User enters desired values
                string nVal = Console.ReadLine();
                Console.WriteLine("Please enter number minimum range");
                string minVal = Console.ReadLine();
                Console.WriteLine("Please enter number maximum range");
                string maxVal = Console.ReadLine();

                int n = 0;
                int min = 0;
                int max = 0;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (int.TryParse(nVal, out n) && int.TryParse(minVal, out min) && int.TryParse(maxVal, out max) && min!=max)    //Input and condition validation
                {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    Console.Write("Your numbers are: ");
                    for (int i = 1; i <= n; i++)                    //Loop repeats until<=n
                    {
                        Random rndSeed = new Random(Guid.NewGuid().GetHashCode());  //Random number. Using this because the delay between every loop is insufficient to let a new seed be generated otherwise(<20ms)
                        int userRandom = rndSeed.Next(min, max+1);  //Generates number in range
                        Console.Write("|" + userRandom + " ");      //Prints seed
                    }
                    Console.WriteLine();        //Simply jumps to the next line
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
