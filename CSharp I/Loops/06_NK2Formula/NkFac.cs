using System;

namespace _06_NK2Formula
{
    /*Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.

Examples:
n 	k 	n! / k!
5 	2 	60
6 	5 	6
8 	3 	6720                                       */
    class NkFac
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

                int kInt = 1;   
                int nInt = 1;

                int nFac = 1;   //These will be used for factorials
                int kFac = 1;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (int.TryParse(nVal, out nInt) && 
                    int.TryParse(kVal, out kInt) && 
                    kInt>1 && nInt>kInt && nInt<100)    //Input validation
                {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    for (int i = 1; i <= nInt; i++) //For loop used for calculations
                    {
                        if (i <= kInt)  //Stops calculating kFac when number input by user is reached
                        {
                            kFac = kFac*i;
                        }
                            nFac = nFac*i;
                    }
                    Console.WriteLine("Your result is : " + nFac/kFac);
                }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Parse unsuccessful. Please check your input and try again");
                }
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
