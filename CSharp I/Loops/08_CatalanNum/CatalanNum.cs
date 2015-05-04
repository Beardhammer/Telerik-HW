using System;
using System.Numerics;

namespace _08_CatalanNum
{
    /*Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

Examples:
n 	Catalan(n)
0 	1
5 	42
10 	16796
15 	9694845                         */
    class CatalanNum
    {
        static void Main()
        {
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Which catalan number do you reqire, sir....?");
                string userNVal = Console.ReadLine();
                BigInteger n = 1;
                BigInteger nFac = 1;    //Formula for catalan numbers is broken up into 3 smaller pieces
                BigInteger nFac2 = 1;
                BigInteger nFac1 = 1;
                BigInteger result = 1;
                if (BigInteger.TryParse(userNVal, out n) && n>=0 && n<=100) //Input validation
                {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    for (int i = 1; i <= 2*n; i++)  //Formula used for calculating catalan numers: (2n)!/(n+1)!*n!
                    {
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (i <= n) //Increases until i>n. Represents n!
                        {
                            nFac *= i;
                        }

                        nFac2 *=i;  //Increases until end of loop. Represents (2*n)!

                        if (i <= (n + 1))   //Increases until i>n+1. Represents (n+1)!
                        {
                            nFac1 *= i;
                        }
                        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    }
                    result = nFac2 / (nFac1 * nFac);
                    Console.WriteLine("\nCatalan number: " + result); //Prnts result
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("Parsing unsuccessful. Please try again. ");
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
