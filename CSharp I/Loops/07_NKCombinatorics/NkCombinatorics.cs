using System;
using System.Numerics;

namespace _07_NKCombinatorics
{
    /*Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

Examples:
n 	k 	n! / (k! * (n-k)!)
3 	2 	3
4 	2 	6
10 	6 	210
52 	5 	2598960                             */
    class NkCombinatorics
    {
        static void Main()
        {
            while (true)
            {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Please enter n");    //User enters n and k. Both will be checked for non-numeric elements
                string nVal = Console.ReadLine();

                Console.WriteLine("Please enter k");
                string kVal = Console.ReadLine();

                BigInteger kInt = 1;
                BigInteger nInt = 1;
                BigInteger x = 1;

                BigInteger nFac = 1;   //These will be used for factorials
                BigInteger kFac = 1;
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (BigInteger.TryParse(nVal, out nInt) &&
                    BigInteger.TryParse(kVal, out kInt) &&
                    kInt > 1 && nInt > kInt && nInt < 100)    //Input validation
                {
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    for (uint i = 1; i <= nInt; i++) //For loop used for calculations
                    {
                        if (i <= kInt)  //Stops calculating kFac when number input by user is reached
                        {
                            kFac = kFac * i;
                        }
                        nFac = nFac*i;
                        if (i <= nInt - kInt)   
                        {
                            x = x*i;
                        }
                    }
                    Console.WriteLine("Your result is : " + (nFac/(kFac*(x)))); //Prints result
                }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Parse unsuccessful. Please check your input and try again"); //In case parsing is usuccessful
                }
            }
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
