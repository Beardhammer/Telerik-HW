using System;

namespace _05_NXFormula
{
    /*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.

Examples:
n 	x 	S
3 	2 	2.75000
4 	3 	2.07407
5 	-4 	0.75781                                 */
    class NxFormula
    {
        static void Main()
        {
            Console.WriteLine("Please enter n");
            while (true)
            {
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                string nVal = Console.ReadLine();

                Console.WriteLine("Please enter x");
                string xVal = Console.ReadLine();
                
                double xDouble = 1;
                double nDouble = 1;
                double nFac = 1;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (double.TryParse(xVal, out xDouble) && double.TryParse(nVal, out nDouble))   //Input validation
                {
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    double result = 1+1/xDouble;    
                    for (int i = 2; i <= nDouble; i++)
                    {
                        nFac = nFac * i;    //Doing calculations here. Very confusing formula. Any idea what it's used for?
                        result += (nFac)/Math.Pow(xDouble,i);   
                    }
                    Console.WriteLine("Yout result is: " + result.ToString("0.00000"));  //Printing with 5 digits after decimal
                }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Parse unsuccessful. Please check your input and try again");
                }
                Console.WriteLine("Wanna try again? Please enter n");   //Program loops around here
            }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
