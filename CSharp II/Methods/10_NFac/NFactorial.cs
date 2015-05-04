using System;
using System.Numerics;

namespace _10_NFac
{
    /*Problem 10. N Factorial

    Write a program to calculate n! for each n in the range [1..100].

Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.                                     */
    class NFactorial
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter your number now\n-->");
                string numVal = Console.ReadLine();
                byte number = 0;
                if (byte.TryParse(numVal, out number) && number <= 100)
                {
                    BigInteger[] factorial = NFac(number);
                    for (int i = 0; i < factorial.Length; i++)
                    {
                        Console.WriteLine("nFac of " + (i + 1) + " is " + factorial[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }

        static BigInteger[] NFac(long num)  //I feel quite sorry for this one. So much potential for optimisation, so little time :( 
        {
            BigInteger[] nax = new BigInteger[num];
            BigInteger fac = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    fac *= j;
                }
                nax[i - 1] = fac;
                fac = 1;
            }
            return nax;
        }
    }
}
