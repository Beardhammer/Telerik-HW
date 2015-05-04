using System;

namespace _13_CompareFloats
{
    /*   Problem 13.* Comparing Floats

    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

Examples:
Number a 	Number b 	Equal (with precision eps=0.000001) 	Explanation
     * 
5.3 	     6.01        	false 	The difference of 0.71 is too big (> eps)
5.00000001 	 5.00000003 	true 	The difference 0.00000002 < eps
5.00000005 	 5.00000001 	true 	The difference 0.00000004 < eps
-0.0000007 	 0.00000007 	true 	The difference 0.00000077 < eps
-4.999999 	 -4.999998  	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different.
4.999999 	 4.999998   	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different.    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enteh ze first number you want to compare");
            for (int i = 1; i <= 50000; i++)    //Loop is used in input validation
            {
                string userInputCheckFloatA = Console.ReadLine();   //Used for input validation
                float userFloatA;   //First number for comparison
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (float.TryParse(userInputCheckFloatA, out userFloatA))   //On failure, loop makes you try again
                {
                    Console.WriteLine("Please enteh ze second number you want to compare");
                    for (int e = 1; e <= 50000; e++)    //Loop here makes sure that if user first value is valid, but second value isn't he doesn't have to enter first value again
                    {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        string userInputCheckFloatB = Console.ReadLine();
                        float userFloatB;
                        if (float.TryParse(userInputCheckFloatB, out userFloatB))   //Input validation
                        {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            if (userFloatA > userFloatB)    //Method of comparison if userFloatA>userFloatB
                            {
                                if (userFloatA - userFloatB < 0.000001)
                                {
                                    Console.WriteLine("numbers " + userFloatA + " and " + userFloatB + " are equal");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("numbers " + userFloatA + " and " + userFloatB + " are not equal");
                                    Console.ReadLine();
                                }
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                            else   ////Method of comparison if userFloatB>userFloatA
                            {
                                if (userFloatB - userFloatA < 0.000001)
                                {
                                    Console.WriteLine("numbers " + userFloatA + " and " + userFloatB + " are equal");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("numbers " + userFloatA + " and " + userFloatB + " are not equal");
                                    Console.ReadLine();
                                }
                            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter second number again");  
                        }
                    }
                }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Invalid input. Please enter first number again");
                }
            }       
        }
    }
}
